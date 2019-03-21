using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClinicSystem.Models;

namespace ClinicSystem.Controllers
{
    public class PatientsController : Controller
    {
        private readonly ClinicSystemContext _context;

        public PatientsController(ClinicSystemContext context)
        {
            _context = context;
        }

        // GET: Patients
        public async Task<IActionResult> Index(string searchString)
        {
            var patients = from m in _context.Patient
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                patients = patients.Where(s => s.FName.Contains(searchString));
            }

            return View(await patients.ToListAsync());
        }

        // GET: Patients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // GET: Patients/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Patients/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Iin,FName,LName,Address,Phone,District")] Patient patient)
        {
            if (ModelState.IsValid)
            {
                _context.Add(patient);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient.FindAsync(id);
            if (patient == null)
            {
                return NotFound();
            }
            return View(patient);
        }

        // POST: Patients/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Iin,FName,LName,Address,Phone,District")] Patient patient)
        {
            if (id != patient.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(patient);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PatientExists(patient.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(patient);
        }

        // GET: Patients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var patient = await _context.Patient
                .FirstOrDefaultAsync(m => m.Id == id);
            if (patient == null)
            {
                return NotFound();
            }

            return View(patient);
        }

        // POST: Patients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _context.Patient.FindAsync(id);
            _context.Patient.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PatientExists(int id)
        {
            return _context.Patient.Any(e => e.Id == id);
        }

        //GET THE FORM FOR VISITS INSERT
        [HttpGet]
        public IActionResult IndexVisit(string iin)
        {
            var visits = from m in _context.Visit
                           select m;

            if (!String.IsNullOrEmpty(iin))
            {
                visits = visits.Where(s => s.PatientIin.Contains(iin));
            }

            return View(visits.ToList());

        }



        // GET: Visits/Create
        public IActionResult CreateVisit(int id)
        {
            ViewBag.Id = id;
            return View();
        }


        // POST: Visits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateVisit([Bind("VisitId,SFName,SLName,Specialist,Complaint,Diagnosis,VisitDate,PatientId,PatientIin")] Visit visit)
        {
            if (ModelState.IsValid)
            {
                _context.Add(visit);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(visit);
        }

        // SEND THE DATA INTO DATABASE.VISITS
        [HttpPost]
        public IActionResult FillVisit(Visit visit)
        {
            _context.Visit.Add(visit);
            visit.VisitDate = DateTime.Now;
            ViewBag.ColDate = visit.VisitDate;
            _context.SaveChanges();
            return View();
        }






    }
}

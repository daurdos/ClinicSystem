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
        
        
        // GET: Поиск пациентов
        public async Task<IActionResult> Index(string patientDistrict, string searchString)
        {
            // Use LINQ to get list of genres.
            IQueryable<string> districtQuery = from m in _context.Patient
                                            orderby m.District
                                            select m.District;

            var patients = from m in _context.Patient
                         select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                patients = patients.Where(s => s.Iin.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(patientDistrict))
            {
                patients = patients.Where(x => x.District == patientDistrict);
            }

            var patientDistrictVM = new DistrictViewModel
            {
                Districts = new SelectList(await districtQuery.Distinct().ToListAsync()),
                Patients = await patients.ToListAsync()
            };

            return View(patientDistrictVM);
        }
        

        // GET: Просмотр деталей пациентов
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
        

        // GET: Получение формы для создания пациентв
        public IActionResult Create()
        {
            return View();
        }
        

        // POST: Отправка данных пациента в БД
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
        

        // GET: получение формы для изменения пациента
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


        // POST: отправка обновленных данных в БД
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


        // GET: удаление пациента
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


        // POST: удаление пациента, обновление БД
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var patient = await _context.Patient.FindAsync(id);
            _context.Patient.Remove(patient);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // Функция возвращает существующих пациентов по id
        private bool PatientExists(int id)
        {
            return _context.Patient.Any(e => e.Id == id);
        }


        //GET: Поиск истории
        [HttpGet]
        public async Task<IActionResult> IndexVisit(string patientSpecialist, string searchString)
        {
            IQueryable<string> SpecialistQuery = from m in _context.Visit
                                               orderby m.Specialist
                                               select m.Specialist;

            var visits = from m in _context.Visit
                           select m;

            if (!string.IsNullOrEmpty(searchString))
            {
                visits = visits.Where(s => s.SLName.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(patientSpecialist))
            {
                visits = visits.Where(x => x.Specialist == patientSpecialist);
            }

            var patientSpecialistVM = new SpecialistViewModel
            {
                Specialists = new SelectList(await SpecialistQuery.Distinct().ToListAsync()),
                Visits = await visits.ToListAsync()
            };

            return View(patientSpecialistVM);
        }


        // GET: создание истории 
         public IActionResult CreateVisit(int id)
         {
             ViewBag.Id = id;
             return View();
         }


        // POST: отправка данных истории в БД
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


        // отправка данных истории в БД
        [HttpPost]
        public IActionResult FillVisit(Visit visit)
        {
            _context.Visit.Add(visit);
            visit.VisitDate = DateTime.Now;
            ViewBag.ColDate = visit.VisitDate;
            _context.SaveChanges();
            return View();
        }


        // GET: изменение истории
        public async Task<IActionResult> EditVisit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visit =  _context.Visit.Find(id);
            if (visit == null)
            {
                return NotFound();
            }
            return View(visit);
        }


        // POST: изменение истории
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditVisit(int id, [Bind("VisitId,SFName,SLName,Specialist,Complaint,Diagnosis,VisitDate,PatientId")] Visit visit)
        {
            if (id != visit.VisitId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(visit);
                   await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VisitExists(visit.VisitId))
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
            return View(visit);
        }


        // GET: удаление истории
        public async Task<IActionResult> DeleteVisit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visit = await _context.Visit
                .FirstOrDefaultAsync(m => m.VisitId == id);
            if (visit == null)
            {
                return NotFound();
            }

            return View(visit);
        }


        // POST: удаление истории
        [HttpPost, ActionName("DeleteVisit")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmedVisit(int id)
        {
            var visit = await _context.Visit.FindAsync(id);
            _context.Visit.Remove(visit);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        // Функция возвращает существующие визиты по id
        private bool VisitExists(int id)
        {
            return _context.Visit.Any(e => e.VisitId == id);
        }


        // GET: Просмотр деталей визитов
        public async Task<IActionResult> DetailsVisit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var visit = await _context.Visit
                .FirstOrDefaultAsync(m => m.VisitId == id);
            if (visit == null)
            {
                return NotFound();
            }

            return View(visit);
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PharmaInventory.Models;
using PharmaInventory.Services;

namespace PharmaInventory.Controllers
{
    public class PharmaController
    {
        private readonly PharmaService _pharmaService;
        private PharmaItem pharmaItem;

        public PharmaController(PharmaService pharmaService)
        {
            _pharmaService = pharmaService;
        }

        public List<PharmaItem> GetAllMed()
        {
            return _pharmaService.GetAllMed();
        }

        public PharmaItem GetMedById(int id)
        {
            return _pharmaService.GetMedById(id);
        }

        public void AddMed(string medName, DateTime medManufactureDate, DateTime medExpireDate, string medDescription)
        {

            var pharmaItem = new PharmaItem
            {
                MedName = medName,
                MedDescription = medDescription,
                MedManufactureDate = medManufactureDate,
                MedExpireDate = medExpireDate,

            };
            _pharmaService.AddMed(pharmaItem);
        }
        public void UpdateMed(int id, string medName, DateTime medManufactureDate, DateTime medExpireDate, string medDescription)
        {
            var pharmaItem = _pharmaService.GetMedById(id);
            if (pharmaItem != null)
            {
                pharmaItem.MedName = medName;
                pharmaItem.MedManufactureDate = medManufactureDate;
                pharmaItem.MedExpireDate = medExpireDate;
                pharmaItem.MedDescription = medDescription;
                _pharmaService.UpdateMed(pharmaItem);
            }
        }

        public void DeleteMed(int id)
        {
            _pharmaService.DeleteMed(id);
        }

        

        
    }
}
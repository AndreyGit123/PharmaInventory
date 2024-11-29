using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PharmaInventory.Controllers;
using PharmaInventory.DAO;
using PharmaInventory.Data;
using PharmaInventory.Services;

namespace PharmaInventory.Forms
{
    public partial class AddForm : Form
    {
        private readonly PharmaController _pharmaController;
        public event Action MedAdded;
        public AddForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var pharmaRepository = new PharmaRepository(context);
            var pharmaService = new PharmaService(pharmaRepository);
            _pharmaController = new PharmaController(pharmaService);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string medName = txtMedname.Text.Trim();
            string medManufactureDateText = txtManufactureDate.Text.Trim();
            string medExpireDateText = txtExpiryDate.Text.Trim();
            string medDescription = txtmedDescription.Text.Trim();

            // Validate required fields
            if (string.IsNullOrEmpty(medName))
            {
                MessageBox.Show("Medicine name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(medDescription))
            {
                MessageBox.Show("Medicine description is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplication (case-insensitive)
            var existingMed = _pharmaController.GetAllMed()
                .FirstOrDefault(m => m.MedName.Equals(medName, StringComparison.OrdinalIgnoreCase));

            if (existingMed != null)
            {
                MessageBox.Show($"The medicine '{medName}' already exists. Please use a different name.", "Duplication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Try parsing the dates
                DateTime medManufactureDate = DateTime.Parse(medManufactureDateText);
                DateTime medExpireDate = DateTime.Parse(medExpireDateText);

                // Ensure expiry date is after manufacture date
                if (medExpireDate <= medManufactureDate)
                {
                    MessageBox.Show("Expiry date must be later than the manufacture date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Add the medicine
                _pharmaController.AddMed(medName, medManufactureDate, medExpireDate, medDescription);
                MessageBox.Show("Added Successfully!", "Information");

                // Raise the event to notify the Main Form
                MedAdded?.Invoke();
                this.Close();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid date format. Please enter a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}

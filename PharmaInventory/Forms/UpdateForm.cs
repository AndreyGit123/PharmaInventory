using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.IdentityModel.Tokens;
using PharmaInventory.Controllers;
using PharmaInventory.DAO;
using PharmaInventory.Data;
using PharmaInventory.Models;
using PharmaInventory.Services;

namespace PharmaInventory.Forms
{
    public partial class UpdateForm : Form
    {
        private readonly PharmaController _noteController;
        public event Action<PharmaItem> MedUpdated;

        private PharmaController _pharmaController;
        private PharmaItem _meds;
        private PharmaItem? pharmaItem;

        public UpdateForm(PharmaItem pharmaItem)
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var pharmaRepository = new PharmaRepository(context);
            var pharmaService = new PharmaService(pharmaRepository);
            _pharmaController = new PharmaController(pharmaService);

            _meds = pharmaItem;
            PopulateFormFields();
        }
        private void PopulateFormFields()
        {

            if (_meds != null)
            {
                // Assuming the form has TextBox controls named `txtSubject` and `txtDescription`
                uptmedName.Text = _meds.MedName;
                uptmanufacturedDate.Text = _meds.MedManufactureDate.ToString("yyyy-MM-dd");
                uptexpiryDate.Text = _meds.MedExpireDate.ToString("yyyy-MM-dd");
                uptDescription.Text = _meds.MedDescription.ToString();
                // Add more fields as needed
            }
        }

        private void updateMedBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve and trim form values
                string updatedMedName = uptmedName.Text.Trim();
                string manufactureDateText = uptmanufacturedDate.Text.Trim();
                string expiryDateText = uptexpiryDate.Text.Trim();
                string updatedDescription = uptDescription.Text.Trim();

                // Validate required fields
                if (string.IsNullOrWhiteSpace(updatedMedName) || string.IsNullOrWhiteSpace(updatedDescription))
                {
                    MessageBox.Show("Medicine name and description are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate and parse dates
                if (!DateTime.TryParse(manufactureDateText, out DateTime manufactureDate) ||
                    !DateTime.TryParse(expiryDateText, out DateTime expiryDate))
                {
                    MessageBox.Show("Please enter valid dates for manufacture and expiry.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (expiryDate <= manufactureDate)
                {
                    MessageBox.Show("Expiry date must be after the manufacture date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Check for duplicate medicine names (excluding current)
                var duplicateMed = _pharmaController.GetAllMed()
                    .FirstOrDefault(m => m.MedName.Equals(updatedMedName, StringComparison.OrdinalIgnoreCase) && m.Id != _meds.Id);

                if (duplicateMed != null)
                {
                    MessageBox.Show($"The medicine '{updatedMedName}' already exists.", "Duplication Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Update medication details
                _meds.MedName = updatedMedName;
                _meds.MedManufactureDate = manufactureDate;
                _meds.MedExpireDate = expiryDate;
                _meds.MedDescription = updatedDescription;

                // Update through controller and notify the main form
                _pharmaController.UpdateMed(_meds.Id, updatedMedName, manufactureDate, expiryDate, updatedDescription);
                MessageBox.Show("Medicine updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MedUpdated?.Invoke(_meds);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
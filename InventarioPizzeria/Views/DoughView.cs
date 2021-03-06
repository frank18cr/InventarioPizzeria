﻿using InventarioPizzeriaDAL.DA;
using InventarioPizzeriaDAL.DTO;
using InventarioPizzeriaDAL.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioPizzeria.Views
{
    public partial class DoughView : Form
    {
        private int editingID;
        private bool editMode;
        private DoughDA dataAccess;
        private DoughOperation operation;

        public DoughView(DoughOperation operation)
        {
            InitializeComponent();
            DoughGridView.AutoGenerateColumns = false;
            dataAccess = new DoughDA();
            this.operation = operation;
            SetTitle(operation);
            if(Global.CurrentUserLevel != UserType.Admin)
            {
                filtroLbl.Visible = false;
                hastaLbl.Visible = false;
                filtroDtpFrom.Visible = false;
                filtroDtpTo.Visible = false;
            }
        }

        private void SetTitle(DoughOperation operation)
        {
            switch (operation)
            {
                case DoughOperation.Burnt:
                    lblTitle.Text = "Masa Quemada";
                    break;
                case DoughOperation.Initial:
                    lblTitle.Text = "Masa Inicial";
                    break;
                case DoughOperation.Remaining:
                    lblTitle.Text = "Sobrante de Masa";
                    break;
                case DoughOperation.Split:
                    lblTitle.Text = "Corte de Masa";
                    break;
            }
        }

        private void BurntDough_Load(object sender, EventArgs e)
        {
            dataAccess = new DoughDA();
            InitializeGridView();
        }

        private void InitializeGridView()
        {
            DateTime from, to;
            if(Global.CurrentUserLevel != UserType.Admin)
            {
                from = to = DateTime.Now;
            }
            else
            {
                from = filtroDtpFrom.Value;
                to = filtroDtpTo.Value;
            }
            DoughGridView.DataSource = dataAccess.getOperationDough(operation, Global.CurrentShop, from, to);
        }

        private void DoughGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewImageColumn &&
                e.RowIndex >= 0)
            {
                try
                {
                    var dough = (DoughDTO)senderGrid.Rows[e.RowIndex].DataBoundItem;
                    if (e.ColumnIndex == 5)
                    {
                        populateEditDough(dough);
                    }
                    else if (e.ColumnIndex == 6)
                    {
                        deleteDough(dough.ID);
                    }
                }
                catch (Exception ex)
                {

                }

            }
        }

        private void deleteDough(int doughId)
        {
            dataAccess.deleteDough(doughId);
            InitializeGridView();
        }

        private void populateEditDough(DoughDTO dough)
        {
            editMode = true;
            editingID = dough.ID;
            gramsTbx.Text = dough.Grams.ToString();
            cookTbx.Text = dough.CookName;
            datePicker.Text = dough.Date.ToString();
            detailPanel.Show();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            bool result;
            DoughDTO dough = new DoughDTO(int.Parse(gramsTbx.Text), DateTime.Parse(datePicker.Text), cookTbx.Text, operation, Global.CurrentShop);
            if (editMode)
            {
                dough.ID = editingID;
            }

            result = dataAccess.saveDough(dough);

            if (result)
            {
                clearAndHideForm();
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            clearAndHideForm();
        }

        private void clearAndHideForm()
        {
            gramsTbx.Clear();
            cookTbx.Clear();
            editingID = 0;
            editMode = false;
            detailPanel.Hide();

            InitializeGridView();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            detailPanel.Show();
        }

        private void numericTexbox_TextChanged(object sender, EventArgs e)
        {
            TextBox senderButton = (TextBox)sender;
            if (System.Text.RegularExpressions.Regex.IsMatch(senderButton.Text, "[^-0-9]"))
            {
                MessageBox.Show("Por favor usar solo numeros");
                senderButton.Text = senderButton.Text.Remove(senderButton.Text.Length - 1);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filtroDtpFrom_ValueChanged(object sender, EventArgs e)
        {
            InitializeGridView();
        }
    }
}

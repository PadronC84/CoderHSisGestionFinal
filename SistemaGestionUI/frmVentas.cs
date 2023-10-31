﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaGestionBusiness;
using SistemaGestionData;

namespace SistemaGestionEntities
{
    public partial class frmVentas : Form
    {
        public frmVentas()
        {
            InitializeComponent();
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            {
                ListarVenta();
            }

            void ListarVenta()
            {
                List<Venta> lista = VentaBusiness.ListarVenta();
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = lista;
            }

        }
    }
}

﻿using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Payment : Form
    {
        private PaymentService service;
        public Payment()
        {
            InitializeComponent();
            service = new PaymentService();
        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }
    }
}

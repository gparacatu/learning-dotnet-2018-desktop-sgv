#region Copyright Syncfusion Inc. 2001 - 2017
// Copyright Syncfusion Inc. 2001 - 2017. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace APRESENTACAO
{
    public partial class FrmCalculadora : Syncfusion.Windows.Forms.Tools.RibbonForm
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        private void FrmCalculadora_Leave(object sender, EventArgs e)
        {

        }

        private void FrmCalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(ControleFormulario.frmCalculadora != null)
            {
                ControleFormulario.frmCalculadora = null;
            }
        }
    }
}

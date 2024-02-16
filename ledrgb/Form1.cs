using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ledrgb
{
    public partial class Form1 : Form
    {
        bool mueve;
        int valor;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                serialPort1.PortName = txtPuerto.Text;
                serialPort1.Open();
                btnConectar.Visible = false;
                txtPuerto.Visible = false;
                btnApagar.Visible = true;
                btnAzul.Visible = true;
                btnRandom.Visible = true;
                btnRojo.Visible = true;
                btnVerde.Visible = true;
                lblAzul.Visible = true;
                lblRojo.Visible = true;
                lblVerde.Visible = true;
                tbAzul.Visible = true;
                tbRojo.Visible = true;
                tbVerde.Visible = true;
                btnDesconectar.Visible = true;
                MessageBox.Show("Se estableció la comunicación con la tarjeta Arduino", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }

        }

        public void reinicia()
        {
            timer.Stop();
            tbAzul.Value = 0;
            tbRojo.Value = 0;
            tbVerde.Value = 0;
            lblVerde.Text = "0";
            lblRojo.Text = "0";
            lblAzul.Text = "0";

        }
        private void btnRojo_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                reinicia();
                tbRojo.Value = 255;
                lblRojo.Text = "255";
                pictureBox1.Image = Properties.Resources.boton_rojo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            reinicia();
            timer.Interval = 1000;
            timer.Start();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("4");
                reinicia();
                pictureBox1.Image = Properties.Resources.boton_blanco;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAzul_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("2");
                reinicia();
                tbAzul.Value = 255;
                lblAzul.Text = "255";
                pictureBox1.Image = Properties.Resources.boton_azul;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("3");
                reinicia();
                tbVerde.Value = 255;
                lblVerde.Text = "255";
                pictureBox1.Image = Properties.Resources.botonverde;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        


        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();
                btnConectar.Visible = false;
                txtPuerto.Visible = false;
                btnApagar.Visible = true;
                btnAzul.Visible = true;
                btnRandom.Visible = true;
                btnRojo.Visible = true;
                btnVerde.Visible = true;
                lblAzul.Visible = true;
                lblRojo.Visible = true;
                lblVerde.Visible = true;
                tbAzul.Visible = true;
                tbRojo.Visible = true;
                tbVerde.Visible = true;
                btnDesconectar.Visible = true;

                MessageBox.Show("Se cerro la comunicacion con la tarjeta Arduino", "Informacion",MessageBoxButtons.OK ,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
        }

        private void tbRojo_Scroll(object sender, EventArgs e)
        {

        }

        private void tbRojo_MouseDown(object sender, MouseEventArgs e)
        {
            mueve = true;

        }

        private void tbAzul_MouseDown(object sender, MouseEventArgs e)
        {
            mueve = true;
        }

        private void tbVerde_MouseDown(object sender, MouseEventArgs e)
        {
            mueve= true;
        }

        private void tbRojo_MouseMove(object sender, MouseEventArgs e)
        {
            if (mueve == true)
            {
                valor = tbRojo.Value;
                lblRojo.Text = valor.ToString();
            }

        }

        private void tbAzul_MouseMove(object sender, MouseEventArgs e)
        {
            if (mueve == true)
            {
                valor = tbAzul.Value;
                lblAzul.Text = valor.ToString();
            }
        }

        private void tbVerde_MouseMove(object sender, MouseEventArgs e)
        {
            if (mueve == true)
            {
                valor = tbVerde.Value;
                lblVerde.Text = valor.ToString();
            }
        }


        public void envia1()
        {
            if (valor > 200)
                serialPort1.Write("a");
            else if (valor> 150)
                serialPort1.Write("b");
            else if (valor>100)
                serialPort1.Write("c");
            else if (valor>50)
                serialPort1.Write("d");
            else if (valor>0)
                serialPort1.Write("e");
            else if (valor ==0)
                serialPort1.Write("f");
        }

        public void envia2()
        {
            if (valor > 200)
                serialPort1.Write("r");
            else if (valor > 150)
                serialPort1.Write("s");
            else if (valor > 100)
                serialPort1.Write("t");
            else if (valor > 50)
                serialPort1.Write("u");
            else if (valor > 0)
                serialPort1.Write("v");
            else if (valor == 0)
                serialPort1.Write("w");
        }

        public void envia3()
        {
            if (valor > 200)
                serialPort1.Write("A");
            else if (valor > 150)
                serialPort1.Write("B");
            else if (valor > 100)
                serialPort1.Write("B");
            else if (valor > 50)
                serialPort1.Write("C");
            else if (valor > 0)
                serialPort1.Write("D");
            else if (valor == 0)
                serialPort1.Write("E");
        }
        private void tbRojo_MouseUp(object sender, MouseEventArgs e)
        {
            mueve = false;
            envia1();
        }

        private void tbAzul_MouseUp(object sender, MouseEventArgs e)
        {
            mueve = false;
            envia2();
        }

        private void tbVerde_MouseUp(object sender, MouseEventArgs e)
        {
            mueve = false;
            envia3();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                serialPort1.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}


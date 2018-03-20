using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataGridView;

namespace Retrasos
{
    public partial class Form1 : Form
    {

        SqlConnection conn = new SqlConnection("Data Source=LAPTOP-2M9GPQKQ\\IVANN;Initial Catalog=ALUMNOS;Persist Security Info=False; User id=sa; Password=123456");
        SqlDataReader dr = null;
        SqlCommand cmd = null;
        SqlDataAdapter da;
        DataTable dt;


        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtrut.Text != "")
            {

                string query = "SELECT Alumnos.Run, " +
                                    "Alumnos.NombreCompleto, " +
                                    "Alumnos.Curso , " +
                                    "count( Atrasados.RutAtraso) as Total_Atrasos " +
                                    "FROM Alumnos " +
                                    "LEFT JOIN Atrasados ON Alumnos.Run = Atrasados.RutAtraso " +
                                    "WHERE Alumnos.Rut = '" +txtrut.Text + "' " +
                                    "group by Alumnos.Run, Alumnos.NombreCompleto, Alumnos.Curso";

                cmd = new SqlCommand( query , conn);

                conn.Open();

                try
                {
                    dr = cmd.ExecuteReader();
                    
                    if(dr.Read() == true)
                    {

                        txtrut.Enabled = false;
                        
                        btningresar.Enabled = false;
                        btnactualizar.Enabled = true;
                        txtnombre.Enabled = true;
                        txtcurso.Enabled = true;
                        txtrun.Enabled = true;
                        txtAtrasos.Enabled = true;
                        txtnombre.Text = dr["NombreCompleto"].ToString();
                        txtcurso.Text = dr["Curso"].ToString();
                        txtrun.Text = dr["Run"].ToString();
                        txtAtrasos.Text = dr["Total_Atrasos"].ToString();
                        conn.Close();

                        if (File.Exists("c:\\Imagenes\\" + txtrut.Text + ".jpg"))
                        {
                            pictureBox2.Image = System.Drawing.Image.FromFile("c:\\Imagenes\\" + txtrut.Text + ".jpg");
                            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                        }
                        else
                        {
                            pictureBox2.Image = System.Drawing.Image.FromFile("c:\\Imagenes\\Default.jpg");
                        }

                        conn.Open();
                        string insertar = "insert into [ALUMNOS].[dbo].[Atrasados](RutAtraso,FechaHora) values('" + txtrun.Text + "','" + lblhora.Text + "')";
                        cmd = new SqlCommand(insertar, conn);
                        cmd.ExecuteReader();
                        conn.Close();

                        Conexion con = new Conexion();
                        DgvAlumnos.DataSource = con.tabla("select * from Atrasados where RutAtraso='"+ txtrun.Text + "'");


                        dr.Close();

                    }
                    else
                    {
                        MessageBox.Show("No existe el alumno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtrut.Text = "";
                        txtrut.Enabled = true;
                        btnactualizar.Enabled = false;
                        btningresar.Enabled = true;
                        txtnombre.Text = "";
                        txtrun.Text = "";
                        txtcurso.Text = "";
                        txtnombre.Enabled = false;
                        txtcurso.Enabled = false;
                        txtrun.Enabled = false;
                        
                    }
              
                }
                finally
                {
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnactualizar.Enabled = false;
            txtnombre.Enabled = false;
            txtcurso.Enabled = false;
            txtrun.Enabled = false;
            txtAtrasos.Enabled = false;
            

        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            txtrut.Enabled = true;
            btnactualizar.Enabled = false;
            btningresar.Enabled = true;
            txtnombre.Text = "";
            txtrun.Text = "";
            txtcurso.Text = "";
            txtAtrasos.Text = "";
            txtrut.Text = "";
            txtnombre.Enabled = false;
            txtcurso.Enabled = false;
            txtrun.Enabled = false;
            txtAtrasos.Enabled = false;
            pictureBox2.Image = null;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString();
        }

        private void txtrut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Solo ingresar numeros.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        
    }
}

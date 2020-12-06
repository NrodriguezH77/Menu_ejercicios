using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO; // escritura lectura
using System.Xml.Serialization; // manejo de archivos xlm

namespace AppEstudiantes
{
    public partial class Form1 : Form
    {
        // Declarar objetos
        //ArrayList listaAlumno = new ArrayList();

        //instanciar clase de validacion

        ValidarCajas validacion = new ValidarCajas();


        List<Estudiante> listaAlumnos = new List<Estudiante>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // cargar datos xml
            // generar lista con esos datos
            //mostrar esa lista en dg
            this.AutoScroll = true;

            listaAlumnos.Clear();

           if (File.Exists("C:/Users/Usuario/Documents/TRIMESTRE III/PROGRAMACIÓN/carpeta_alumnos/listaAlumnos.xlm"))
            {
                XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiante>));
                FileStream leerXml = File.OpenRead("C:/Users/Usuario/Documents/TRIMESTRE III/PROGRAMACIÓN/carpeta_alumnos/listaAlumnos.xlm");
                listaAlumnos = (List<Estudiante>)codificador.Deserialize(leerXml);
                leerXml.Close();
            }
            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;

           
        }

        private void tsAddUser_Click(object sender, EventArgs e)
        {
            //codigo para validar y agregar alumno

            if (!validacion.Vacio(txtcodigoin, errorM, "El codigo no puede ser vacio"))
                if (validacion.TipoNumero(txtcodigoin, errorM, "Debe digitar numeros"))
                    if (!validacion.Vacio(txtnombrein, errorM, "El nombre no puede ser vacio"))
                        if (validacion.TipoTexto(txtnombrein, errorM, "Debe digitar texto"))
                            if (!validacion.Vacio(txtcorreoin, errorM, "El correo no puede ser vacio"))
                                if (validacion.TipoCorreo(txtcorreoin, errorM, "El correo no puede ser vacio"))
                                    if (!validacion.Vacio(txtnota1in, errorM, "La nota no puede ser vacio"))
                                        if (validacion.TipoNumero(txtnota1in, errorM, "Debe digitar numeros"))
                                            if (!validacion.Vacio(txtnota2in, errorM, "La nota no puede ser vacio"))
                                                if (validacion.TipoNumero(txtnota2in, errorM, "Debe digitar numeros"))
                                                    if (!validacion.Vacio(txtnota3in, errorM, "La nota no puede ser vacio"))
                                                        if (validacion.TipoNumero(txtnota3in, errorM, "Debe digitar numeros"))
                                                            if (!validacion.Vacio(txtnota4in, errorM, "La nota no puede ser vacio"))
                                                                if (validacion.TipoNumero(txtnota4in, errorM, "Debe digitar numeros"))
                                                                {
                                                                    if (!ExisteCodigo(Convert.ToInt32(txtcodigoin.Text)))
                                                                    {
                                                                        insertarDatos();
                                                                        LimpiarCajas();
                                                                        errorM.Clear();
                                                                    }else
                                                                    {
                                                                        errorM.SetError(txtcodigoin, "El código ya existe");
                                                                        txtcodigoin.Focus();
                                                                        return;
                                                                    }
                                                                       
                                                                    
                                                                }
                       
        }

        private void verArreglo()
        {
            foreach (Estudiante itemAlumno in listaAlumnos)
            {
                Console.WriteLine("---------------------");

                Console.WriteLine(itemAlumno.Codigo);
                Console.WriteLine(itemAlumno.Nombre);
                Console.WriteLine(itemAlumno.Correo);
                Console.WriteLine(itemAlumno.Nota1);
                Console.WriteLine(itemAlumno.Nota2);
                Console.WriteLine(itemAlumno.Nota3);
                Console.WriteLine(itemAlumno.Nota4);
                Console.WriteLine(itemAlumno.notaFinal);
                Console.WriteLine(itemAlumno.notaConcepto);

                Console.WriteLine("---------------------");
            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            // crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiante>));
            TextWriter escribirXml = new StreamWriter("C:/Users/Usuario/Documents/TRIMESTRE III/PROGRAMACIÓN/carpeta_alumnos/listaAlumnos.xlm");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
            //C:\Users\Usuario\Documents\TRIMESTRE III\PROGRAMACIÓN\carpeta_alumnos 
        }

        

        private void tsOpenFile_Click_1 (object sender, EventArgs e)
        {
            // cargar datos xml
            // generar lista con esos datos
            //mostrar esa lista en dg
            listaAlumnos.Clear();
            XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiante>));
            FileStream leerXml = File.OpenRead("C:/Users/Usuario/Documents/TRIMESTRE III/PROGRAMACIÓN/carpeta_alumnos/listaAlumnos.xlm");
            listaAlumnos = (List<Estudiante>)codificador.Deserialize(leerXml);
            leerXml.Close();

            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
        }

        private void insertarDatos()
        {
            // -------Agregar alumno

            Estudiante objetoAlumno = new Estudiante(); //Se instancia la clase Estudiante y se crea el objeto objetoAlumno
            // desde los elementos  del formulario creo alumno nuevo
            objetoAlumno.Codigo = Convert.ToInt32(txtcodigoin.Text);
            objetoAlumno.Nombre = txtnombrein.Text;
            objetoAlumno.Correo = txtcorreoin.Text;
            objetoAlumno.Nota1 = Convert.ToDouble(txtnota1in.Text);
            objetoAlumno.Nota2 = Convert.ToDouble(txtnota2in.Text);
            objetoAlumno.Nota3 = Convert.ToDouble(txtnota3in.Text);
            objetoAlumno.Nota4 = Convert.ToDouble(txtnota4in.Text);

            objetoAlumno.notaFinal = (objetoAlumno.Nota1 + objetoAlumno.Nota2 + objetoAlumno.Nota3 + objetoAlumno.Nota4) / 4;

            if (objetoAlumno.notaFinal >= 3.5) //ahorramos corchetes proque es una sola linea tanto en el if como el else
                objetoAlumno.notaConcepto = "Aprobado";
            else
                objetoAlumno.notaConcepto = "Reprobado";

            //agregar objeto al arreglo
            listaAlumnos.Add(objetoAlumno);

            //vizualizo en el DG el arreglo
            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;
        }

        private void LimpiarCajas()
        {
            txtcodigoin.Clear();
            txtnombrein.Clear();
            txtcorreoin.Clear();
            txtnota1in.Clear();
            txtnota2in.Clear();
            txtnota3in.Clear();
            txtnota4in.Clear();

            txtcodigoin.Focus();

        }
        private void LimpiarCajas2()
        {
            
            txtnombrein.Clear();
            txtcorreoin.Clear();
            txtnota1in.Clear();
            txtnota2in.Clear();
            txtnota3in.Clear();
            txtnota4in.Clear();

            txtcodigoin.Focus();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // crear archivo xml
            XmlSerializer codificador = new XmlSerializer(typeof(List<Estudiante>));
            TextWriter escribirXml = new StreamWriter("C:/Users/Usuario/Documents/TRIMESTRE III/PROGRAMACIÓN/carpeta_alumnos/listaAlumnos.xlm");
            codificador.Serialize(escribirXml, listaAlumnos);
            escribirXml.Close();
            //C:\Users\Usuario\Documents\TRIMESTRE III\PROGRAMACIÓN\carpeta_alumnos 
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private Boolean ExisteCodigo(int codigo)
        {
            foreach  (Estudiante myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                   return true;
                
               
            }
            return false;
        }

        private void tsSearchUser_Click(object sender, EventArgs e)
        {

            // validar que no este vacio
             if(!validacion.Vacio(txtcodigoin, errorM, "Para buscar debe haber un codigo"))
                if (validacion.TipoNumero(txtcodigoin, errorM, "Debe digitar numeros"))
                {
                    //validar si existe
                    if (ExisteCodigo(Convert.ToInt32(txtcodigoin.Text)))
                    {
                        Estudiante myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
                        txtnombrein.Text = myAlumno.Nombre;
                        txtcorreoin.Text = myAlumno.Correo;
                        txtnota1in.Text = myAlumno.Nota1.ToString();
                        txtnota2in.Text = myAlumno.Nota2.ToString();
                        txtnota3in.Text = myAlumno.Nota3.ToString();
                        txtnota4in.Text = myAlumno.Nota4.ToString();

                        //Activar los botones

                        tsEditUser.Enabled = true;
                        tsDeleteUser.Enabled = true;
                        txtcodigoin.Enabled = false;

                    }
                    else
                    {
                        errorM.SetError(txtcodigoin, "El código no existe en la lista");                        
                        LimpiarCajas2();
                        return;
                    }

                }
                        
        }

        //se trae el objeto que contiene los datos del alumno segun el codigo
        private Estudiante obtenerDatos(int codigo)
        {
            foreach (Estudiante myAlumno in listaAlumnos)
            {
                if (myAlumno.Codigo == codigo)
                {
                    return myAlumno;
                }
            }
            return null;
        }

        private void tsEditUser_Click(object sender, EventArgs e)
        {

            //Editar datos
            
                    if (!validacion.Vacio(txtnombrein, errorM, "El nombre no puede ser vacio"))
                        if (validacion.TipoTexto(txtnombrein, errorM, "Debe digitar texto"))
                            if (!validacion.Vacio(txtcorreoin, errorM, "El correo no puede ser vacio"))
                                if (validacion.TipoCorreo(txtcorreoin, errorM, "El correo no puede ser vacio"))
                                    if (!validacion.Vacio(txtnota1in, errorM, "La nota no puede ser vacio"))
                                        if (validacion.TipoNumero(txtnota1in, errorM, "Debe digitar numeros"))
                                            if (!validacion.Vacio(txtnota2in, errorM, "La nota no puede ser vacio"))
                                                if (validacion.TipoNumero(txtnota2in, errorM, "Debe digitar numeros"))
                                                    if (!validacion.Vacio(txtnota3in, errorM, "La nota no puede ser vacio"))
                                                        if (validacion.TipoNumero(txtnota3in, errorM, "Debe digitar numeros"))
                                                            if (!validacion.Vacio(txtnota4in, errorM, "La nota no puede ser vacio"))
                                                                if (validacion.TipoNumero(txtnota4in, errorM, "Debe digitar numeros"))
                                                                    guardarCambios();


                                                                


        }

        private void guardarCambios()
        {
            //Editar datos

            Estudiante myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
            myAlumno.Nombre = txtnombrein.Text;
            myAlumno.Correo = txtcorreoin.Text;
            myAlumno.Nota1 = Convert.ToDouble(txtnota1in.Text);
            myAlumno.Nota2 = Convert.ToDouble(txtnota2in.Text);
            myAlumno.Nota3 = Convert.ToDouble(txtnota3in.Text);
            myAlumno.Nota4 = Convert.ToDouble(txtnota4in.Text);

            myAlumno.notaFinal = (myAlumno.Nota1 + myAlumno.Nota2 + myAlumno.Nota3 + myAlumno.Nota4) / 4;

            if (myAlumno.notaFinal >= 3.5) //ahorramos corchetes proque es una sola linea tanto en el if como el else
                myAlumno.notaConcepto = "Aprobado";
            else
                myAlumno.notaConcepto = "Reprobado";



            dgTablaDatos.DataSource = null;
            dgTablaDatos.DataSource = listaAlumnos;

            // habilitar botones
            tsDeleteUser.Enabled = false;
            tsEditUser.Enabled = false;
            txtcodigoin.Enabled = true;

            LimpiarCajas();

        }

        private void tsDeleteUser_Click(object sender, EventArgs e)
        {
            //borrar datos del estudiante

            DialogResult confirmarborrar = MessageBox.Show("¿Está seguro que desea eliminar al usuario?", "Cuidado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (confirmarborrar == DialogResult.OK)
            {
                Estudiante myAlumno = obtenerDatos(Convert.ToInt32(txtcodigoin.Text));
                listaAlumnos.Remove(myAlumno);

                dgTablaDatos.DataSource = null;
                dgTablaDatos.DataSource = listaAlumnos;

                // habilitar botones
                tsDeleteUser.Enabled = false;
                tsEditUser.Enabled = false;
                txtcodigoin.Enabled = true;
               
                LimpiarCajas();
            } 

        }
    }

}

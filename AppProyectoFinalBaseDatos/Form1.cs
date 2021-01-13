using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppProyectoFinalBaseDatos
{
    public partial class Form1 : Form
    {
        string consulta = "";
        DataSet ds = new DataSet();
        //
        string tabla;
        string indice;
        string columna;
        string nuevoDato;
        //
        
        public Form1()
        {
            InitializeComponent();
        }

        private void cmbMenuServidores_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string conexionSolicitada;
            conexionSolicitada = this.cmbMenuServidores.GetItemText(this.cmbMenuServidores.SelectedItem);
            Datos.EstablecerConexion(conexionSolicitada);
            lblAviso.Text = "Usted está conectado con: " +conexionSolicitada;
            cbMenuDeTrablas.Enabled = true;
            btnSelect.Enabled = true;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            try
            {
                consulta = "SELECT * FROM " + cbMenuDeTrablas.Text + " WHERE estatus=1";
                Datos.AgregarDataTable(ds, consulta, "Hospital", dataGridView1);
            }
            catch
            {
                MessageBox.Show("Usted no ha seleccionado una tabla para mostrar");
            }
        }

        private void btnModificarRegistro_Click(object sender, EventArgs e)
        {
            tabla = this.cbMenuDeTrablas.GetItemText(this.cbMenuDeTrablas.SelectedItem);
            indice = (txtIndice.Text);
            columna = (txtColumna.Text);
            nuevoDato = (txtNuevoDato.Text);

            try
            {
             consulta = "UPDATE " + tabla + " SET " + columna + "= " + "'" + nuevoDato + "'" + " WHERE id" + tabla + "=" + indice;
             Datos.EjecutarComando(consulta);
            }
            catch
            {
            MessageBox.Show("Datos ingresados incorrectos, no se pudo actualizar el registro de la tabla " + tabla);

            }
        }

        private void bntEliminarRegistro_Click(object sender, EventArgs e)
        {
            tabla = this.cbMenuDeTrablas.GetItemText(this.cbMenuDeTrablas.SelectedItem);
            indice = (txtIndice.Text);

            try
            {

                consulta = "DELETE FROM " + tabla + " WHERE id" + tabla + "=" + indice;
                Datos.EjecutarComando(consulta);
            }
            catch 
            {
                MessageBox.Show("Usted está solicitando eliminar un registro cuando la tabla es una foranea en otra tabla, o bien, no se encuentra el indice del registro a eliminar, por favor revise sus datos");

            }
        }
        private void btnAñadirRegistro_Click(object sender, EventArgs e)
        {
            DateTime fechaaUsar = dateTime1.Value;
            string fecha = fechaaUsar.ToString("yyyy-MM-dd");
            try
            {
                switch (cbMenuDeTrablas.Text)
                {

                    case "Convenio":
                        consulta = "INSERT INTO Convenio (tipo) VALUES ('" + txtDato1.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Consultorio":
                        consulta = "INSERT INTO Consultorio (numero) VALUES ('" + int.Parse(txtDato1.Text) + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Diagnostico":
                        consulta = "INSERT INTO Diagnostico (clave,descripcion) VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Enfermedad":
                        consulta = "INSERT INTO Enfermedad (codigo,descripcion) VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Enfermera":
                        consulta = "INSERT INTO Enfermera (rfc,claveArea,nombre,telefono) VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "','" + txtDato4.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "HorarioMedico":
                        consulta = "INSERT INTO HorarioMedico(dia,horaInicio,horaFin) VALUES('" + txtDato1.Text + "','" + time1.Text + "','" + time2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Planta":
                        consulta = "INSERT INTO Planta(numero,nombre,cantCamas) VALUES('" + int.Parse(txtDato1.Text) + "','" + txtDato2.Text + "','" + int.Parse(txtDato3.Text) + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Recepcionista":
                        consulta = "INSERT INTO Recepcionista(rfc, nombre, telefono) VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Paciente":
                        consulta = "INSERT INTO Paciente(nombre, apellidos, fechaNacimiento, sexo, telefono, idConvenio) VALUES('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + fecha + "', '" + txtDato3.Text + "', '" + txtDato4.Text + "', " + int.Parse(txtDato5.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "HistoriaClinica":
                        consulta = "INSERT INTO HistoriaClinica(codigo, fechaElaboracion, descripcion, idPaciente) VALUES('" + txtDato1.Text + "','" + fecha + "', '" + txtDato2.Text + "', " + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Medico":
                        consulta = "INSERT INTO Medico(rfc, nombre, apellidos, telefono, idHorarioMedico, idConsultorio) VALUES('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "', '" + txtDato4.Text + "', " + int.Parse(txtDato5.Text) + "," + int.Parse(txtDato6.Text) + ");";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "Consulta":
                        consulta = "INSERT INTO Consulta(fecha, horaInicio, horaFin, idMedico, idPaciente)VALUES('" + fecha + "', '" + time1.Text + "', '" + time2.Text + "', " + int.Parse(txtDato1.Text) + ", " + int.Parse(txtDato2.Text) + ");";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "PaseVisita":
                        consulta = "INSERT INTO PaseVisita(numero, horaInicio, horaFin, idPaciente)VALUES (" + int.Parse(txtDato1.Text) + ",'" + time1.Text + "', '" + time2.Text + "', " + int.Parse(txtDato2.Text) + ");";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "Cama":
                        consulta = "INSERT INTO Cama (numero, idPaciente, idPlanta)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Receta":
                        consulta = "INSERT INTO Receta (descripcion, idPaciente, idMedico)VALUES ('" + txtDato1.Text + "'," + int.Parse(txtDato2.Text) + "," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "FabricanteMedicina":
                        consulta = "INSERT INTO FabricanteMedicina (nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Farmacia":
                        consulta = "INSERT INTO Farmacia (nombre, direccion)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ProveedorMedicina":
                        consulta = "INSERT INTO ProveedorMedicina (nombre, telefono, idFabricanteMedicina)VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "', " + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;

                    case "Medicina":
                        consulta = "INSERT INTO Medicina(nombre, descripcion, idProveedorMedicina, idFabricanteMedicina)VALUES ('" + txtDato1.Text + "' , '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + " ," + int.Parse(txtDato4.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Farmaceutico":
                        consulta = "INSERT INTO  Farmaceutico(nombre , telefono, idFarmacia)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "AlmacenMedicina":
                        consulta = "INSERT INTO  AlmacenMedicina(numero, totalExistencia, idFarmacia)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "AlmacenInstrumental":
                        consulta = "INSERT INTO  AlmacenInstrumental(numero, totalExistencia)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "FabricanteInstrumental":
                        consulta = "INSERT INTO FabricanteInstrumental (nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ProveedorInstrumental":
                        consulta = "INSERT INTO  ProveedorInstrumental (nombre , telefono, idFabricanteInstrumental)VALUES('" + txtDato1.Text + "', '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + "); ";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "InstrumentalMedico":
                        consulta = "INSERT INTO InstrumentalMedico(nombre, descripcion, idAlmacenInstrumental, idProveedorInstrumental,idFabricanteInstrumental,idMedico)VALUES ('" + txtDato1.Text + "' , '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + " ," + int.Parse(txtDato4.Text) + "," + int.Parse(txtDato5.Text) + "," + int.Parse(txtDato6.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ExamenLaboratorio":
                        consulta = "INSERT INTO ExamenLaboratorio(codigo, descripcion)VALUES('" + txtDato1.Text + "','" + txtDato2.Text + "');";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "Laboratorio":
                        consulta = "INSERT INTO Laboratorio (nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Laboratorista":
                        consulta = "INSERT INTO  Laboratorista(nombre , telefono, idLaboratorio)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ExamenRadiologo":
                        consulta = "INSERT INTO ExamenRadiologo (codigo, descripcion)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Radiologia":
                        consulta = "INSERT INTO Radiologia(nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Radiologo":
                        consulta = "INSERT INTO  Radiologo(nombre,telefono,idRadiologia)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "CertificadoRecoleccion":
                        consulta = "INSERT INTO CertificadoRecoleccion (codigo, descripcion)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "CertificadoSanitizacion":
                        consulta = "INSERT INTO CertificadoSanitizacion(codigo, descripcion)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "FacturaMantenimiento":
                        consulta = "INSERT INTO FacturaMantenimiento(descripcion, totalPagar)VALUES ('" + txtDato1.Text + "', " + decimal.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Mantenimiento":
                        consulta = "INSERT INTO Mantenimiento(descripcion, cantHoraHombre)VALUES ('" + txtDato1.Text + "'," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "TecnicoMantenimiento":
                        consulta = "INSERT INTO TecnicoMantenimiento(nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "RecoleccionBiologica":
                        consulta = "INSERT INTO RecoleccionBiologica(descripcion, cantHoraHombre)VALUES ('" + txtDato1.Text + "'," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "RecolectoraBiologica":
                        consulta = "INSERT INTO RecolectoraBiologica(nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Sanitizacion":
                        consulta = "INSERT INTO Sanitizacion(descripcion, cantHoraHombre)VALUES('" + txtDato1.Text + "', " + int.Parse(txtDato2.Text) + "); ";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Sanitizadora":
                        consulta = "INSERT INTO Sanitizadora(nombre, direccion, telefono)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Administrador":
                        consulta = "INSERT INTO Administrador (matricula, nombre, telefono)VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Caja":
                        consulta = "INSERT INTO Caja (numero)VALUES (" + int.Parse(txtDato1.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ReporteIngresos":
                        consulta = "INSERT INTO ReporteIngresos(descripcion, total)VALUES ('" + txtDato1.Text + "'," + decimal.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Cajero":
                        consulta = "INSERT INTO Cajero(rfc, nombre, telefono, idCaja)VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "','" + txtDato3.Text + "'," + int.Parse(txtDato4.Text) + " );";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "FacturaConsulta":
                        consulta = "INSERT INTO FacturaConsulta(descripcion, totalPagar, idCajero, idPaciente)VALUES('" + txtDato1.Text + "'," + decimal.Parse(txtDato2.Text) + "," + int.Parse(txtDato3.Text) + "," + int.Parse(txtDato4.Text) + "); ";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Nomina":
                        consulta = "INSERT INTO Nomina (codigo, descripcion, total, idAdministrador)VALUES ('" + txtDato1.Text + "', '" + txtDato2.Text + "', '" + txtDato3.Text + "', " + int.Parse(txtDato4.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Emergencias":
                        consulta = "INSERT INTO Emergencias ( telefono)VALUES ('" + txtDato1.Text + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Ambulancia":
                        consulta = "INSERT INTO Ambulancia (numero, matricula, idPaciente)VALUES (" + int.Parse(txtDato1.Text) + ",'" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "Conductor":
                        consulta = "INSERT INTO Conductor (nombre, telefono, idEmergencias)VALUES('" + txtDato1.Text + "', '" + txtDato2.Text + "'," + int.Parse(txtDato3.Text) + "); ";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "HospitalExterno":
                        consulta = "INSERT INTO HospitalExterno ( nombre, direccion, telefono, idPaciente)VALUES ('" + txtDato1.Text + "','" + txtDato2.Text + "', '" + txtDato3.Text + "'," + int.Parse(txtDato4.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    /////-------TABLAS NM-------------
                    case "RecepcionistaConsulta":
                        consulta = "INSERT INTO RecepcionistaConsulta (idRecepcionista, idConsulta)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "); ";
                        Datos.EjecutarComando(consulta);
                        break;

                    case "RecepcionistaPaciente":
                        consulta = "INSERT INTO RecepcionistaPaciente(idRecepcionista, idPaciente )VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;

                    case "MedicoPaciente":
                        consulta = "INSERT INTO MedicoPaciente(idMedico, idPaciente)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;

                    case "EnfermeraPaciente":
                        consulta = "INSERT INTO EnfermeraPaciente(idEnfermera, idPaciente)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "MedicoDiagnostico":
                        consulta = "INSERT INTO MedicoDiagnostico(idMedico, idDiagnostico)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "DiagnosticoPaciente":
                        consulta = "INSERT INTO DiagnosticoPaciente(idPaciente, idDiagnostico, fecha)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "'); ";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "PacienteEnfermedad":
                        consulta = "INSERT INTO PacienteEnfermedad(idPaciente, idEnfermedad)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "DiagnosticoEnfermedad":
                        consulta = "INSERT INTO DiagnosticoEnfermedad(idDiagnostico, idEnfermedad)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "RecetaMedicina":
                        consulta = "INSERT INTO RecetaMedicina(idReceta, idMedicina)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "); ";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "MedicinaFarmaceutico":
                        consulta = "INSERT INTO MedicinaFarmaceutico(idMedicina, idFarmaceutico)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "AlmacenMedicinaMedicina":
                        consulta = "INSERT INTO AlmacenMedicinaMedicina(idAlmacenMedicina, idMedicina)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "); ";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "MedicoExamenRadiologo":
                        consulta = "INSERT INTO MedicoExamenRadiologo(idMedico, idExamenRadiologo)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "MedicoExamenLaboratorio":
                        consulta = "INSERT INTO MedicoExamenLaboratorio(idMedico, idExamenLaboratorio)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "); ";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "LaboratoristaExamenLaboratorio":
                        consulta = "INSERT INTO LaboratoristaExamenLaboratorio(idLaboratorista, idExamenLaboratorio)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "); ";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "RadiologoExamenRadiologo":
                        consulta = "INSERT INTO RadiologoExamenRadiologo(idRadiologo, idExamenRadiologo)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "":
                        consulta = "INSERT INTO ConsultorioMantenimiento(idConsultorio, idMantenimiento,fecha)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "');";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "ConsultorioSanitizacion":
                        consulta = "INSERT INTO ConsultorioSanitizacion(idConsultorio, idSanitizacion,fecha)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ConsultorioRecoleccion":
                        consulta = "INSERT INTO ConsultorioRecoleccion(idConsultorio, idRecoleccionBiologica,fecha)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "TecnicoMantenimientoMantenimiento":
                        consulta = "INSERT INTO TecnicoMantenimientoMantenimiento(idTecnicoMantenimiento, idMantenimiento)VALUES(" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + "); ";

                        Datos.EjecutarComando(consulta);
                        break;
                    case "SanitizadoraSanitizacion":
                        consulta = "INSERT INTO SanitizadoraSanitizacion(idSanitizadora, idSanitizacion)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "RecolectoraRecoleccion":
                        consulta = "INSERT INTO RecolectoraRecoleccion(idRecolectoraBiologica, idRecoleccionBiologica)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "FacturaMantenimientoTecnico":
                        consulta = "INSERT INTO FacturaMantenimientoTecnico(idFacturaMantenimiento, idTecnicoMantenimiento,fecha)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "CertificadoSanitizadora":
                        consulta = "INSERT INTO CertificadoSanitizadora(idCertificadoSanitizacion, idSanitizadora,fecha)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "CertificadoRecolectora":
                        consulta = "INSERT INTO CertificadoRecolectora(idCertificadoRecoleccion, idRecolectoraBiologica,fecha)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ",'" + fecha + "');";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "NominaMedico":
                        consulta = "INSERT INTO NominaMedico(idNomina, idMedico)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "FacturaConsultaMedico":
                        consulta = "INSERT INTO FacturaConsultaMedico(idFacturaConsulta, idMedico)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "ReporteIngresosCajero":
                        consulta = "INSERT INTO ReporteIngresosCajero(idReporteIngresos, idCajero)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;
                    case "AmbulanciaConductor":
                        consulta = "INSERT INTO AmbulanciaConductor(idAmbulancia, idConductor)VALUES (" + int.Parse(txtDato1.Text) + "," + int.Parse(txtDato2.Text) + ");";
                        Datos.EjecutarComando(consulta);
                        break;


                }
                MessageBox.Show("Añadido. Porfavor vuelva a mostrar la tabla");
            }
            catch
            {
                MessageBox.Show("ERROR. Algun dato introducido no tiene el formato correcto");
            }
        }
        // TOOL STRIP MENU ITEMS---------------------------------------------------------------------------------------------
        bool ActivaEvento = false;
        private void mostrarTablasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            groupBoxSecundario.Visible = false;

            groupBox1.Visible = false;
            groupBox4.Visible = false;

            ActivaEvento = false;
            dataGridView1.Location = new Point(12, 202);
            this.Size = new Size(852, 460);
        }

        private void modificarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            groupBoxSecundario.Visible = false;
            groupBox1.Visible = true;
            groupBox4.Visible = true;
            bntEliminarRegistro.Enabled = false;

             ActivaEvento = false;
            dataGridView1.Location = new Point(12, 202);
            this.Size = new Size(852, 460);
        }

        private void eliminarRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            groupBoxSecundario.Visible = false;
            groupBox1.Visible = false;
            groupBox4.Visible = true;
            bntEliminarRegistro.Enabled = true;

             ActivaEvento = false;
            dataGridView1.Location = new Point(12, 202);
            this.Size = new Size(852, 460);
        }

        private void agregarUnRegistroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox4.Visible = false;
            groupBoxSecundario.Visible = true;
            ActivaEvento = true;
            dataGridView1.Location = new Point(12, 242);
            this.Size = new Size(852, 493);

        }
        //-----------------------------------------------------------------------------------------------------------
        private void cbMenuDeTrablas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ActivaEvento == true)
            {
                ActivadorDeTextbox();
            }
        }
        private void ActivadorDeTextbox()
        {
            switch (cbMenuDeTrablas.Text)
            {
                ///////// PRIMER 1 TRUE
                case "Convenio":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = false;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;

                    lblTextoDato1.Text = "Tipo de convenio";
                    lblTextoDato2.Text = "--------------";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                   
                case "Consultorio":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = false;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Numero consultorio";
                    lblTextoDato2.Text = "--------------";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Caja":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = false;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Numero de caja";
                    lblTextoDato2.Text = "--------------";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Emergencias":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = false;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Telefono";
                    lblTextoDato2.Text = "--------------";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                /////////////// PRIMEROS 2 EN TRUE
                case "Diagnostico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Clave de diagnostico";
                    lblTextoDato2.Text = "Descripcion";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Farmacia":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Direccion";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "AlmacenInstrumental":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Numero de almacen";
                    lblTextoDato2.Text = "Total en existencia";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Enfermedad":
                case "ExamenLaboratorio":
                case "ExamenRadiologo":
                case "CertificadoRecoleccion":
                case "CertificadoSanitizacion":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Codigo ";
                    lblTextoDato2.Text = "Descripcion ";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "FacturaMantenimiento":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Descripcion de la factura";
                    lblTextoDato2.Text = "Total pagado";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                
                case "Mantenimiento":
                case "Sanitizacion":
                case "RecoleccionBiologica":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Descripcion";
                    lblTextoDato2.Text = "Cantidad de horas hombre";
                    lblTextoDato3.Text = "Telefono";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "ReporteIngresos":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Descripcion del reporte";
                    lblTextoDato2.Text = "Total";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "RecepcionistaConsulta":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del recepcionista";
                    lblTextoDato2.Text = "id de la consulta";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "RecepcionistaPaciente":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del recepcionista";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "MedicoPaciente":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del medico";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "EnfermeraPaciente":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de la enfermera";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "MedicoDiagnostico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del medico";
                    lblTextoDato2.Text = "id del diagnostico";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "PacienteEnfermedad":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del paciente";
                    lblTextoDato2.Text = "id de la enfermedad";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "DiagnosticoEnfermedad":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del diagnostico";
                    lblTextoDato2.Text = "id de la enfermedad";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "RecetaMedicina":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de la receta";
                    lblTextoDato2.Text = "id de medicina";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "MedicinaFarmaceutico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de medicina";
                    lblTextoDato2.Text = "id del farmaceutico";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "AlmacenMedicinaMedicina":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de almacen";
                    lblTextoDato2.Text = "id de medicina";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "MedicoExamenRadiologo":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del medico";
                    lblTextoDato2.Text = "id examen radiologo";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "MedicoExamenLaboratorio":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del medico";
                    lblTextoDato2.Text = "id examen de laboratorio";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "LaboratoristaLaboratorio":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del laboratorista";
                    lblTextoDato2.Text = "id examen de laboratorio";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "RadiologoExamenRadiologo":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del radiologo";
                    lblTextoDato2.Text = "id examen radiologo";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "TecnicoMantenimientoMantenimiento":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id Tecnico de mantenimiento";
                    lblTextoDato2.Text = "id de mantenimiento";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "SanitizadoraSanitizacion":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id empresa sanitizadora";
                    lblTextoDato2.Text = "id de sanitizacion";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "RecolectoraRecoleccion":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id empresa recolectora";
                    lblTextoDato2.Text = "id recoleccion biologica";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "NominaMedico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de nomina";
                    lblTextoDato2.Text = "id del medico";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "FacturaConsultaMedico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id factura de consulta";
                    lblTextoDato2.Text = "id de medico";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "ReporteIngresosCajero":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id reporte de ingreso";
                    lblTextoDato2.Text = "id del cajero";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "AmbulanciaConductor":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de Ambulancia";
                    lblTextoDato2.Text = "id de conductor";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                /////////////// PRIMEROS 3 EN TRUE
                case "Planta":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Numero";
                    lblTextoDato2.Text = "Nombre";
                    lblTextoDato3.Text = "Cantidad de camas";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Recepcionista":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "RFC";
                    lblTextoDato2.Text = "Nombre";
                    lblTextoDato3.Text = "Telefono";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Cama":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Numero";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "id de planta";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Receta":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Descripcion";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "id del medico";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "ProveedorMedicina":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Telefono";
                    lblTextoDato3.Text = "id fabricante de medicina";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Farmaceutico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Telefono";
                    lblTextoDato3.Text = "id de farmacia";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "AlmacenMedicina":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Numero de almacen";
                    lblTextoDato2.Text = "Total en existencia";
                    lblTextoDato3.Text = "id de farmacia";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "ProveedorInstrumental":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Telefono";
                    lblTextoDato3.Text = "id fabricante instrumental";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Laboratorista":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Telefono";
                    lblTextoDato3.Text = "id de laboratorio";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Radiologo":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Telefono";
                    lblTextoDato3.Text = "id de radiologia";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "FabricanteMedicina":
                case "FabricanteInstrumental":
                case "Laboratorio":
                case "Radiologia":
                case "TecnicoMantenimiento":
                case "RecolectoraBiologica":
                case "Sanitizadora":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Dirección";
                    lblTextoDato3.Text = "Telefono";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Administrador":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Matricula";
                    lblTextoDato2.Text = "Nombre";
                    lblTextoDato3.Text = "Telefono";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Ambulancia":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Numero";
                    lblTextoDato2.Text = "Matricula";
                    lblTextoDato3.Text = "id de paciente";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Conductor":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Telefono";
                    lblTextoDato3.Text = "id de emergencias";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
               
                case "DiagnosticoPaciente":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id paciente";
                    lblTextoDato2.Text = "id diagnostico";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;

                case "ConsultorioMantenimiento":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id consultorio";
                    lblTextoDato2.Text = "id mantenimiento tecnico";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "ConsultorioSanitizacion":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id consultorio";
                    lblTextoDato2.Text = "id sanitizacion";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "ConsultorioRecoleccion":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id consultorio";
                    lblTextoDato2.Text = "id recoleccion biologica";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                
                case "Enfermera":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "RFC";
                    lblTextoDato2.Text = "Clave de area";
                    lblTextoDato3.Text = "Nombre";
                    lblTextoDato4.Text = "Telefono";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "FacturaConsulta":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Descripcion";
                    lblTextoDato2.Text = "Total a pagar";
                    lblTextoDato3.Text = "id del cajero";
                    lblTextoDato4.Text = "id del paciente";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Cajero":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "RFC";
                    lblTextoDato2.Text = "Nombre";
                    lblTextoDato3.Text = "Telefono";
                    lblTextoDato4.Text = "id de caja";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Nomina":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Codigo de nomina";
                    lblTextoDato2.Text = "Descripcion";
                    lblTextoDato3.Text = "Total";
                    lblTextoDato4.Text = "id del administrador";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "HospitalExterno":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Nombre del hospital";
                    lblTextoDato2.Text = "Direccion";
                    lblTextoDato3.Text = "Telefono";
                    lblTextoDato4.Text = "id del paciente";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "Medicina":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = false;
                    time2.Enabled = false;
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Descripcion";
                    lblTextoDato3.Text = "id de su proveedor";
                    lblTextoDato4.Text = "id de su fabricante";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
               
                case "Paciente":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = true;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Apelidos";
                    lblTextoDato3.Text = "sexo";
                    lblTextoDato4.Text = "Telefono";
                    lblTextoDato5.Text = "id de convenio";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "HistoriaClinica":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Codigo de historial";
                    lblTextoDato2.Text = "Descripcion";
                    lblTextoDato3.Text = "id del paciente";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;

                case "Consulta":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = true;//inicio
                    time2.Enabled = true;//fin
                    lblTextoDato1.Text = "id del medico";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "PaseVisita":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = true;//inicio
                    time2.Enabled = true;//fin
                    lblTextoDato1.Text = "Numero de pase";
                    lblTextoDato2.Text = "id del paciente";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;

                case "HorarioMedico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = false;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = false;
                    time1.Enabled = true;
                    time2.Enabled = true;
                    lblTextoDato1.Text = "Dia";
                    lblTextoDato2.Text = "--------------";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;

                case "InstrumentalMedico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = true;
                    txtDato6.Enabled = true;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "Nombre";
                    lblTextoDato2.Text = "Descripcion";
                    lblTextoDato3.Text = "id Almacen instrumental";
                    lblTextoDato4.Text = "id Proveedor instrumental";
                    lblTextoDato5.Text = "id Fabricante instrumental";
                    lblTextoDato6.Text = "id Medico";
                    break;
                case "Medico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = true;
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = true;
                    txtDato6.Enabled = true;
                    dateTime1.Enabled = false;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "RFC del medico";
                    lblTextoDato2.Text = "Nombre del medico";
                    lblTextoDato3.Text = "Apellido del medico";
                    lblTextoDato4.Text = "Telefono del medico";
                    lblTextoDato5.Text = "id Horario Medico";
                    lblTextoDato6.Text = "id Consultorio";
                    break;
                case "FacturaMantenimientoTecnico":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id de la factura";
                    lblTextoDato2.Text = "id Tecnico mantenimiento";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "CertificadoSanitizadora":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del certificado";
                    lblTextoDato2.Text = "id de sanitizadora";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
                case "CertificadoRecolectora":
                    txtDato1.Enabled = true;
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                    txtDato6.Enabled = false;
                    dateTime1.Enabled = true;//fecha
                    time1.Enabled = false;//inicio
                    time2.Enabled = false;//fin
                    lblTextoDato1.Text = "id del certificado";
                    lblTextoDato2.Text = "id de recolectora";
                    lblTextoDato3.Text = "--------------";
                    lblTextoDato4.Text = "--------------";
                    lblTextoDato5.Text = "--------------";
                    lblTextoDato6.Text = "--------------";
                    break;
            }
        }
    }
}
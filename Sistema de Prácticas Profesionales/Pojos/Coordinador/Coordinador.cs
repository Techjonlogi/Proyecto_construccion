using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Prácticas_Profesionales.Pojos.Coordinador
{
    public class Coordinador
    {
        private int idCoordinador;
        private String nombresCoordinador;
        private String apellidoPaternoCoordinador;
        private String apellidoMaternoCoordinador;
        private String usuarioCoordinador;
        private String contraseñaCoordinador;


        public int IdCoordinador { get => idCoordinador; set => idCoordinador= value; }

        public string NombresCoordinador { get => nombresCoordinador; set => nombresCoordinador = value; }

        public string ApellidoPaternoCoordinador { get => apellidoPaternoCoordinador; set => apellidoPaternoCoordinador = value; }

        public string ApellidoMaternoCoordinador { get => apellidoMaternoCoordinador; set => apellidoMaternoCoordinador = value; }

        public string UsuarioCoordinador { get => usuarioCoordinador; set => usuarioCoordinador = value; }

        public string ContraseñaCoordinador { get => contraseñaCoordinador; set => contraseñaCoordinador = value; }

        public Coordinador(int id) {
            this.idCoordinador = id;
        }
    }
}

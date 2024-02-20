using sitioplatzi.Models;
using System.Linq;
namespace sitioplatzi.Datos {
    public class Conexion {
        private ContactoContext conect;
        public Conexion(ContactoContext conn) {
            conect = conn;
        }

        public List<Contacto> getData() {
            return conect.ContactSet.ToList();
        }

        public Contacto getContacto(int id) {
            var micon = (from c in conect.ContactSet
            where c.IdContacto == id
            select c).FirstOrDefault();
            return micon;

        }

        public int insertar(Contacto reg) {
            Contacto urung = reg;
            conect.ContactSet.Add(urung);
            conect.SaveChanges();
            return 1;
        }

        public int actualiza(int id, Contacto valu) {
            Contacto reg=valu;
            var esto =conect.ContactSet.Find(reg.IdContacto);
            esto.Nombre =valu.Nombre;
            esto.Telefono=valu.Telefono;
            esto.Correo=valu.Correo;
            conect.SaveChanges();
            return 1;
        }

        public int Delete(int id) {
            var selelem =conect.ContactSet.Find(id);
            conect.ContactSet.Remove(selelem);
            conect.SaveChanges();
            return 1;
        }
    }
}
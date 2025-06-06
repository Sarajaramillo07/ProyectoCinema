﻿using Lib_Dominio.Entidades;

namespace lib_aplicaciones.Interfaces
{
    public interface ISedesAplicacion
    {
        void Configurar(string StringConexion);
        List<Sedes> PorCodigo(Sedes? entidad);
        List<Sedes> Listar();
        Sedes? Guardar(Sedes? entidad);
        Sedes? Modificar(Sedes? entidad);
        Sedes? Borrar(Sedes? entidad);
    }
}

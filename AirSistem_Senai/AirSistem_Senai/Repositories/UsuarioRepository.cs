using AirSistem_Senai.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirSistem_Senai.Repositories
{
    public class UsuarioRepository
    {
        private static List<Usuario> usuarios;

        private static int contador = 1;

        public UsuarioRepository()
        {
            if(usuarios == null)
            {
                usuarios = new List<Usuario>();

                usuarios.Add(new Usuario
                {
                    id = 1,
                    nome = "Carlos",
                    sobrenome = "Eduardo",
                    endereco = "Rua das alamedas",
                    numero = "77",
                    usuario = "cadudu",
                    senha = "1243"  
                }
                );
                contador++;
                usuarios.Add(new Usuario
                {
                    id = 2,
                    nome = "Roberto",
                    sobrenome = "Campos",
                    endereco = "Rua dos Palmares",
                    numero = "12",
                    usuario = "robertinho",
                    senha = "1230"
                }
                );
                contador++;
            }
        }

        public List<Usuario> buscarTodos()
        {
            return usuarios;
        }

        public void adicionar (Usuario usuario)
        {
            usuario.id = contador;
            usuarios.Add(usuario);
            contador++;
        }

        public void editar(Usuario usuario)
        {
            Usuario u;
            foreach (Usuario x in usuarios)
            {
                if (x.id == usuario.id)
                {
                    u = x;
                }
            }

        }

        public void deletar (int id)
        {

            Usuario usuario = usuarios.Find(x => x.id == id);
            usuarios.Remove(usuario);
        }
    }
}

namespace QRA.Enumerators.Content
{
    public class CuentaEnumerador
    {
        public enum EstadoCuenta : byte
        {
            Inactivo = 0,
            Activo = 1,
            Suspendido = 2,
            Bloqueado = 3
        }

        public enum TipoCuenta : byte
        {
            Master = 0,
            Administrador = 1,
            Funcionario = 2,
            Propietario = 3,
            Invitado = 4
        }
    }
}

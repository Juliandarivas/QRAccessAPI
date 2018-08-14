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
    }
}

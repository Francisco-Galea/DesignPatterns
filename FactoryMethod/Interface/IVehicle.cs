namespace FactoryMethod.Interface
{
    /// <summary>
    /// Estos metodos son imlementados en cada clase que implemente a la interfaz.
    /// Deben implementarlos OBLIGATORIAMENTE, ya que es un contrato.
    /// ¿Como se implementan? Eso lo define su propia clase, cada uno puede definir
    /// su implementacion a gusto, pero debe respetar los parametros de ingreso y el retorno
    /// para no violar el principio de sustitucion de LISKOV.
    /// </summary>
    public interface IVehicle
    {
        void Start();
        void Stop();
        void GetInfo();
    }
}

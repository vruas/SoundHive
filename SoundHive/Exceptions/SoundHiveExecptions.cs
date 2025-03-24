using System.Runtime.Serialization;


namespace SoundHive.Exceptions;

[Serializable]
public class SoundHiveExecptions : Exception
{
    public SoundHiveExecptions() : base("ERRO: Ocorreu um erro inesperado.")
    {
    }
    public SoundHiveExecptions(string message) : base(message)
    {

    }

    public SoundHiveExecptions(string message, Exception innerException) : base(message, innerException)
    {

    }

    protected SoundHiveExecptions(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}

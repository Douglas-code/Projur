using Projur.Domain.Commands.Contracts;

namespace Projur.Domain.Commands
{
    public class GenericCommandResult<T> : ICommandResult
    {
        public GenericCommandResult() { }

        public GenericCommandResult(bool success, string message, T data)
        {
            this.Success = success;
            this.Message = message;
            this.Data = data;
        }

        public bool Success { get; set; }

        public string Message { get; set; }

        public T Data { get; set; }
    }
}

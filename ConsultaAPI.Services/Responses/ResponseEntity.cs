using System;
using System.Runtime.Serialization;


namespace ConsultaAPI.Services.Responses
{
    [Serializable]
    [DataContract]
    public class ResponseEntity<T>
    {
        [DataMember]
        public bool Success { get; set; }        
        [DataMember]
        public T Data { get; set; }
        [DataMember]
        public string Message { get; set; }
    }
}

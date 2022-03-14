using Majorkey.Models;

public interface IServicesRequestService
{
    Task<Guid> CreateServiceRequest(ServiceRequest serviceRequest);
    Task<ServiceRequest> ReadServiceRequest(Guid id);
    Task<IEnumerable<ServiceRequest>> ReadServicesRequest();
    Task<Guid> UpdatePais(ServiceRequest serviceRequest);
    Task<Guid> DeletePais(Guid id);    

}

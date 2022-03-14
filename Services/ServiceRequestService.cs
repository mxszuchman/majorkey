using Majorkey.Models;

namespace Majorkey.Services;

public static class ServiceRequestService
{
    static List<ServiceRequest> ServicesRequests { get; }
    static Guid nextId = Guid.NewGuid();
    static ServiceRequestService()
    {
        ServicesRequests = new List<ServiceRequest>
        {
            new ServiceRequest { 
                Id = Guid.NewGuid(),
                buildingCode = "COH",
                description = "Please turn up the AC in suite 1200D. It is too hot here.",
                currentStatus = CurrentStatus.Created,
                createdBy = "Nik Patel",
                createdDate = new DateTime(2019, 8, 1, 14, 25, 43, DateTimeKind.Utc),
                lastModifiedBy = "Jane Doe",
                lastModifiedDate = new DateTime(2019, 8, 1, 15, 01, 23, DateTimeKind.Utc)
            },
            new ServiceRequest { 
                Id = Guid.NewGuid(),
                buildingCode = "COH",
                description = "Please turn up the AC in suite 1200D. It is too hot here.",
                currentStatus = CurrentStatus.InProgress,
                createdBy = "Pepe",
                createdDate = new DateTime(2019, 8, 1, 14, 25, 43, DateTimeKind.Utc),
                lastModifiedBy = "Jane Doe",
                lastModifiedDate = new DateTime(2019, 8, 1, 15, 01, 23, DateTimeKind.Utc)

            }
        };
    }

    public static List<ServiceRequest> GetAll() => ServicesRequests;

    public static ServiceRequest? Get(Guid id) => ServicesRequests.FirstOrDefault(s => s.Id == id);

    public static void Add(ServiceRequest serviceRequest)
    {
        serviceRequest.Id = Guid.NewGuid();
        ServicesRequests.Add(serviceRequest);
    }

    public static void Delete(Guid id)
    {
        var serviceRequest = Get(id);
        if(serviceRequest is null)
            return;

        ServicesRequests.Remove(serviceRequest);
    }

    public static void Update(ServiceRequest serviceRequest)
    {
        var index = ServicesRequests.FindIndex(s => s.Id == serviceRequest.Id);
        if(index == -1)
            return;

        ServicesRequests[index] = serviceRequest;
    }
}
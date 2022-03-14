using Majorkey.Models;
using Majorkey.Services;
using Microsoft.AspNetCore.Mvc;

namespace Majorkey.Controllers;

[ApiController]
[Route("[controller]")]
public class ServiceRequestController : ControllerBase
{
    public ServiceRequestController()
    {
    }

    [HttpGet]
        public ActionResult<List<ServiceRequest>> GetAll() =>
        ServiceRequestService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<ServiceRequest> Get(Guid id)
    {
        var serviceRequest = ServiceRequestService.Get(id);

        if(serviceRequest == null)
            return NotFound();

        return serviceRequest;
    }

    [HttpPost]
    public IActionResult Create(ServiceRequest serviceRequest)
    {            
        ServiceRequestService.Add(serviceRequest);
        return CreatedAtAction(nameof(Create), new { id = serviceRequest.Id }, serviceRequest);
    }

    [HttpPut("{id}")]
    public IActionResult Update(Guid id, ServiceRequest serviceRequest)
    {
        if (id != serviceRequest.Id)
            return BadRequest();
            
        var existingServiceRequest = ServiceRequestService.Get(id);
        if(existingServiceRequest is null)
            return NotFound();
    
        ServiceRequestService.Update(serviceRequest);           
    
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var serviceRequest = ServiceRequestService.Get(id);
    
        if (serviceRequest is null)
            return NotFound();
        
        ServiceRequestService.Delete(id);
    
        return NoContent();
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace {{Namespace}};

#region auto-generated code © Breno Van-Dall - Júnior Belem
[ApiController]
[Route("api/{{EntityName}}")]
public class {{EntityName}}Controller : ControllerBase
{
    private readonly I{{EntityName}}Repository _repository;
    
    public {{EntityName}}Controller(I{{EntityName}}Repository repository)
    {
        _repository = repository;
    }

    [HttpPost()]
    public async Task<IActionResult> Add({{EntityName}} request, CancellationToken cancellationToken)
    {
        var response = _repository.Add(request, cancellationToken);

        return Created();
    }
    
    [HttpPut()]
    public async Task<IActionResult> Update({{EntityName}} request, CancellationToken cancellationToken)
    {
        var response = _repository.Update(request, cancellationToken);

        return Ok();
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id, CancellationToken cancellationToken)
    {
        var response = _repository.GetById(id, cancellationToken);

        return Ok(response);
    }
    
    [HttpGet()]
    public async Task<IActionResult> GetAll(CancellationToken cancellationToken)
    {
        var response = _repository.GetAll(cancellationToken);

        return Ok(response);
    }
    
    [HttpDelete()]
    public async Task<IActionResult> Delete({{EntityName}} request, CancellationToken cancellationToken)
    {
        var response = _repository.Delete(request, cancellationToken);

        return Ok(response);
    }
}
#endregion
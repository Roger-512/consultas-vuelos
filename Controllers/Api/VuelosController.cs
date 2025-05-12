using Microsoft.AsNetCore.Mvc;

[Route("api/vuelos")]
public class VuelosController : ControllerBase{

    [HttpGet("cuidades-origen")]
    public IActionResult CiudadesOrigen(){
        return Ok();
    }

    [HttpGet("cuidades-destino")]
    public IActionResult CiudadesDestino(){
        return Ok();
    }

    [HttpGet("estatus")]
    public IActionResult ListarEstatus(){
        return Ok();
    }

    [HttpGet("listar-vuelos")]
    public IActionResult ListarVuelos(){
        return Ok();
    }
}
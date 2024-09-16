﻿using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecure.Presentation.Abstraction;


[ApiController]
[Route("api/[controller]")]
public abstract class ApiController : ControllerBase
{
    public readonly IMediator _mediator;
    protected ApiController(IMediator mediator)
    {
        _mediator = mediator;
    }
}

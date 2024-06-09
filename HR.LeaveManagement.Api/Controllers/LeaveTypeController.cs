using HR.LeaveManagement.Application.Features.LeaveType.Commands.CreateLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.DeleteLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Commands.UpdateLeaveType;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetAllLeaveTypes;
using HR.LeaveManagement.Application.Features.LeaveType.Queries.GetLeaveTypeDetails;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.LeaveManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LeaveTypeController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LeaveTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<LeaveTypeController>
        [HttpGet]
        public async Task<List<LeaveTypeDto>> Get()
        {
            var leaveTypes = await _mediator.Send(new GetLeaveTypesQuery());
            return leaveTypes;
        }

        // GET api/<LeaveTypeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveTypeDetailsDto>> Get(int id)
        {
            return Ok(await _mediator.Send(new GetLeaveTypeDetailsQuery(id)));
        }

        // POST api/<LeaveTypeController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult> Post(CreateLeaveTypeCommand createLeaveTypeCommand)
        {
            var response = await _mediator.Send(createLeaveTypeCommand);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<LeaveTypeController>/5
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateLeaveTypeCommand updateLeaveTypeCommand)
        {
            var response = await _mediator.Send(updateLeaveTypeCommand);
            return NoContent();
        }

        // DELETE api/<LeaveTypeController>/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            await _mediator.Send(new DeleteLeaveTypeCommand(id));
            return NoContent();
        }
    }
}

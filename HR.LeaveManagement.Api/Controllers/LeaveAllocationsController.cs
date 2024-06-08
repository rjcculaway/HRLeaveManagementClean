using HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocationDetails;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Queries.GetLeaveAllocations;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HR.LeaveManagement.Api.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LeaveAllocationsController : ControllerBase {
        private readonly IMediator _mediator;

        public LeaveAllocationsController(IMediator mediator) {
            this._mediator = mediator;
        }
        // GET: api/<LeaveAllocationsController>
        [HttpGet]
        public async Task<ActionResult<List<LeaveAllocationDto>>> Get(bool isLoggedInUser = false) {
            return Ok(await _mediator.Send(new GetLeaveAllocationListQuery()));
        }

        // GET api/<LeaveAllocationsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LeaveAllocationDto>> Get(int id) {
            return Ok(await _mediator.Send(new GetLeaveAllocationDetailQuery { Id = id }));
        }

        // POST api/<LeaveAllocationsController>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Post(CreateLeaveAllocationCommand createLeaveAllocationCommand) {
            var response = await _mediator.Send(createLeaveAllocationCommand);
            return CreatedAtAction(nameof(Get), new { id = response });
        }

        // PUT api/<LeaveAllocationsController>/5
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Put(UpdateLeaveAllocationCommand updateLeaveAllocationCommand) {
            await _mediator.Send(updateLeaveAllocationCommand);
            return NoContent();
        }

        // DELETE api/<LeaveAllocationsController>/5
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(DeleteLeaveAllocationCommand deleteLeaveAllocationCommand) {
            await _mediator.Send(deleteLeaveAllocationCommand);
            return NoContent();
        }
    }
}

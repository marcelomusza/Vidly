using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Vidly.Dtos;
using Vidly.Models;
using AutoMapper;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/Customers
        public IEnumerable<CustomerDTO> GetCustomers()
        {
            return _context.Customers.ToList().Select(Mapper.Map<Customer, CustomerDTO>);
        }

        //GET /api/customers/1
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return NotFound();

            return Ok(Mapper.Map<Customer, CustomerDTO>(customer));
        }

        //POST /api/customers
        [HttpPost]
        public IHttpActionResult CreateCustomer(CustomerDTO customerDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customer = Mapper.Map<CustomerDTO, Customer>(customerDTO);

            _context.Customers.Add(customer);
            _context.SaveChanges();

            customerDTO.Id = customer.Id;

            return Created(new Uri(Request.RequestUri + "/" + customer.Id), customerDTO);
        }

        //PUT /api/customers/1
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDTO customerDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                return NotFound();

            Mapper.Map(customerDTO, customerInDB);

            _context.SaveChanges();

            return Ok();
        }

        //DELETE /api/customers/1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {

            var customerInDB = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customerInDB == null)
                return NotFound();

            _context.Customers.Remove(customerInDB);
            _context.SaveChanges();

            return Ok();

        }

    }
}

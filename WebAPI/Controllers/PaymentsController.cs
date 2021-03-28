﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        ICardService _cardService;
        IPaymentService _paymentService;

        public PaymentsController(IPaymentService paymentService, ICardService cardService)
        {
            _paymentService = paymentService;
            _cardService = cardService;
        }

        [HttpPost("payment")]
        public ActionResult Payment(Payment payment)
        {
            var result = _paymentService.Add(payment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("savecard")]
        public ActionResult SaveCard(Card card)
        {
            var result = _cardService.Add(card);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("listcards")]
        public ActionResult GetCardsByCustomerId(int customerId)
        {
            var result = _cardService.GetByCustomerId(customerId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
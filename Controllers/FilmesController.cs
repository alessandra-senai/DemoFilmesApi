﻿using DemoFilmesApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoFilmesApi.Controllers
{
    [Route("api/filmes")]
    [ApiController]
    public class FilmesController : ControllerBase
    {
        // GET: api/<FilmesController>
        [HttpGet]
        public IEnumerable<Filme> Get()
        {
            return MockFilmes.Filmes;
        }

        // GET api/<FilmesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<FilmesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<FilmesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FilmesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

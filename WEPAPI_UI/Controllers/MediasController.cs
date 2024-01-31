﻿using Business.Abstract;
using Business.Constants;
using Entities.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEPAPI_UI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediasController : ControllerBase
    {
        IMediaService _mediaService;

        public MediasController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        [HttpPost("AddBlogMedia")]
        public async Task<IActionResult> AddBlogMedia(IFormFile file,Guid BlogId)
        {
            var result = await _mediaService.AddBlogMedia(file,BlogId);
            return !result.Success ? BadRequest(Messages.MediaNotAdded) : Ok(result);
        }
        [HttpPost("AddUserMedia")]
        public async Task<IActionResult> AddUserMedia(IFormFile file, Guid UserId)
        {
            var result = await _mediaService.AddUserMedia(file, UserId);
            return !result.Success ? BadRequest(Messages.MediaNotAdded) : Ok(result); 
        }
        [HttpGet("GetAllMediaDetails")]
        public async Task<IActionResult> GetAllMediaDetails()
        {
            var result = await _mediaService.GetAllMediaDetails();
            return !result.Success ? BadRequest(Messages.MediaNotListed) : Ok(result.Data);
        }
        [HttpDelete("DeleteMedia")]
        public async Task<IActionResult> Delete(Guid MediaId)
        {
            try
            {
                await _mediaService.Delete(MediaId);
                return Ok(Messages.MediaDeleted);
            }
            catch (Exception ex)
            {

                return BadRequest(Messages.MediaNotDeleted);
            }
        }
        [HttpPut("UpdateMedia")]
        public async Task<IActionResult> UpdateMedia(Guid MediaId,IFormFile file)
        {
            var result = await _mediaService.Update(file, MediaId);
            return !result.Success ? BadRequest(Messages.MediaNotUpdated) : Ok(result);
        }
        [HttpGet("GetMediaByBlogId")]
        public async Task<IActionResult> GetMediaByBlogId(Guid BlogId)
        {
            var result = await _mediaService.GetMediaByBlogId(BlogId);
            return !result.Success ? BadRequest(Messages.MediaNotListed) : Ok(result.Data);
        }
        [HttpGet("GetMediaByUserId")]
        public async Task<IActionResult> GetMediaByUserId(Guid UserId)
        {
            var result = await _mediaService.GetMediaByUserId(UserId);
            return !result.Success ? BadRequest(Messages.MediaNotListed) : Ok(result.Data);
        }
    }
}
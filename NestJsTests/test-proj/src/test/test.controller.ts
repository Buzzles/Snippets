import { Controller, Get, Post, Body, Patch, Param, Delete } from '@nestjs/common';

@Controller('test')
export class TestController {
  constructor() {}

  @Get()
  test(): string {
    return "This is a test";
  }

  @Get(':id')
  testval(@Param('id') id: string) {
    return `This is a test ${id}`;
  }
}

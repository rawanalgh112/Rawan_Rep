import { Controller, Get, Post, Body } from '@nestjs/common';
import { UserService } from './user.service';
import { CreateUserDto } from './dto/create-user.dto';

@Controller('users')
export class UserController {
  constructor(private readonly userService: UserService) {}


  @Post('/createuser')
  async create(@Body() createUserDto: CreateUserDto) {
   
   //return createUserDto;
  return this.userService.create(createUserDto);
  }

  @Post('/deleteuser')
  async delete(@Body() body: { id: number }) {
    const { id } = body;  // Extract the 'id' from the body
    await this.userService.delete(id);  // Call the service to delete the user
    return { message: `User with ID ${id} deleted successfully` };
  }

  @Get('')
  async findAll() {
    return this.userService.findAll();
  }
}

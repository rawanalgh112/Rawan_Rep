
import { Controller, Get, Post, Body, Patch, Param, Delete } from '@nestjs/common';
import { ArticleService } from './article.service';
import { CreateArticleDto } from './dto/create-article.dto';
import { faker } from '@faker-js/faker';
@Controller('articles')
export class ArticleController {
  constructor(private readonly ArticleService: ArticleService) {}

  @Post('/create')
  async create(@Body() createArticleDto: CreateArticleDto) {
   

   return this.ArticleService.createArticle(createArticleDto);
  }

  @Post('/create-multiple')  // Endpoint to create multiple fake articles
  async createMultiple() {
    // Initialize an empty array to store the fake articles
    const createArticleDtos: CreateArticleDto[] = [];

    // Loop to generate 20 fake articles
    for (let i = 0; i < 20; i++) {
      const createArticleDto: CreateArticleDto = {
        title: faker.lorem.sentence(),
        body: faker.lorem.paragraph(),
      };

      // Push the generated article into the array
      createArticleDtos.push(createArticleDto);
    }

    // Pass the array of fake articles to the service to save them to the database
    return this.ArticleService.createMultipleArticles(createArticleDtos);
  }

}

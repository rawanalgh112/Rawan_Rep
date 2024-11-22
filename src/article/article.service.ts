// article.service.ts
import { HttpException, HttpStatus, Injectable } from '@nestjs/common';
import { InjectRepository } from '@nestjs/typeorm';
import { Repository } from 'typeorm';
import { Article } from './entities/article.entity';
import { CreateArticleDto } from './dto/create-article.dto';
@Injectable()
export class ArticleService {
  constructor(
    @InjectRepository(Article)
    private readonly articleRepository: Repository<Article>, // Injecting the repository directly
  ) {}

  // Create an article
  async createArticle(createArticleDto: CreateArticleDto) {
    const { title, body } = createArticleDto;
// Creating a new article entity

    try {
        const article = this.articleRepository.create({ title, body });
        await  this.articleRepository.save(article); 
        return { message: 'Article created', article };
  
      } catch (error) {
        console.error('Error saving user:', error);
        throw new HttpException('Internal server error', HttpStatus.INTERNAL_SERVER_ERROR);
    
      }


  }


  async createMultipleArticles(createArticleDtos: CreateArticleDto[]): Promise<Article[]> {
    // Create an array of Article entities from the DTOs
    const articles = this.articleRepository.create(createArticleDtos);

    // Bulk save the articles to the database
    return this.articleRepository.save(articles);
  }
  // Other methods like find, update, delete...
}

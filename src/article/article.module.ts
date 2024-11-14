// article.module.ts
import { Module } from '@nestjs/common';
import { TypeOrmModule } from '@nestjs/typeorm';
import { ArticleService } from './article.service';
import { Article } from './entities/article.entity';
import { ArticleController } from './article.controller'; 
@Module({
  imports: [TypeOrmModule.forFeature([Article])], // Import the Article entity with forFeature
  providers: [ArticleService],
  controllers: [ArticleController], 
  exports: [ArticleService], // Make the ArticleService available to other modules if needed
})
export class ArticleModule {}

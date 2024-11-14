import { Module } from '@nestjs/common';
import { AppController } from './app.controller';
import { AppService } from './app.service';
import { ItemModule } from './item/item.module';
import { UserModule } from './user/user.module';
import { TypeOrmModule } from '@nestjs/typeorm';
import { ArticleController } from './article/article.controller';
import { ArticleService } from './article/article.service';
import { ArticleModule } from './article/article.module';
import { Article } from './article/entities/article.entity';

const entitiesPath = __dirname + '/**/*.entity{.ts,.js}';


@Module({
  imports: [
    ItemModule,
    UserModule, ArticleModule,
    TypeOrmModule.forRoot({
      type: 'postgres',
      host: 'localhost',
      port: 5432,
      username: 'postgres',
      password: '',
      database: 'postgres',
      entities: [Article],
      synchronize: false,
      logging: false,
    }),

  ],
  controllers: [AppController],
  providers: [AppService],
})
export class AppModule {}



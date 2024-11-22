import { Column, PrimaryGeneratedColumn } from 'typeorm';
import { Entity } from 'typeorm/decorator/entity/Entity';


@Entity('article')
export class Article {

  @PrimaryGeneratedColumn()
  id: number;

  
  @Column()
  title: string;

  @Column()
  body: string;


}




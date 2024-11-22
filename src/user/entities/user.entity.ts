import { Column, PrimaryGeneratedColumn } from 'typeorm';
import { Entity } from 'typeorm/decorator/entity/Entity';


@Entity('user')
export class User {

  @PrimaryGeneratedColumn()
  id: number;

  
  @Column()
  fullName: string;

  @Column()
  age: number;

  @Column({ default: 0 })
  following: number;

  @Column({ default: 0 })
  followers: number;

}



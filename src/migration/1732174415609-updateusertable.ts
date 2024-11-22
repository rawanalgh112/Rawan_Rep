import { MigrationInterface, QueryRunner } from "typeorm";

export class Updateusertable1732174415609 implements MigrationInterface {
    name = 'Updateusertable1732174415609'

    public async up(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`ALTER TABLE "user" ADD "following" integer NOT NULL DEFAULT '0'`);
        await queryRunner.query(`ALTER TABLE "user" ADD "followers" integer NOT NULL DEFAULT '0'`);
    }

    public async down(queryRunner: QueryRunner): Promise<void> {
        await queryRunner.query(`ALTER TABLE "user" DROP COLUMN "followers"`);
        await queryRunner.query(`ALTER TABLE "user" DROP COLUMN "following"`);
    }

}

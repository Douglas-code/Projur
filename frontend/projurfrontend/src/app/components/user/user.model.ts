import { Schooling } from "src/app/utils/enums/schooling.enum";

export class User{
    id?: number;
    name?: string;
    surname?: string;
    email?: string;
    birthDate?: string;
    schooling?: Schooling;

    constructor(){}
}
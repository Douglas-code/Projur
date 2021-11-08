import { Component, OnInit } from '@angular/core';
import { Schooling } from 'src/app/utils/enums/schooling.enum';
import { GenericResult } from 'src/app/utils/models/GenericResult';
import { User } from '../user.model';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user-read',
  templateUrl: './user-read.component.html',
  styleUrls: ['./user-read.component.css']
})
export class UserReadComponent implements OnInit {
  displayedColumns = ["name", "email", "birthDate", "schooling", "actions"];
  users: User[] = [];

  constructor(private userService: UserService) { }

  ngOnInit(): void {
    this.findAllUsers();
  }

  findAllUsers(){
    this.userService.read().subscribe(GenericResult =>{
      this.users = GenericResult.data;
    });
  }

  delete(id: number){
    this.userService.delete(id).subscribe(genericResult =>{
      this.userService.showMessage(genericResult.message, !genericResult.success);
      this.findAllUsers();
    });
  }

  intToEnum(num: number): string{
    return Schooling[num].toString();
  }

}

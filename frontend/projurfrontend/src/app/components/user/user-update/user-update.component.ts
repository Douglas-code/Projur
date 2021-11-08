import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Schooling } from 'src/app/utils/enums/schooling.enum';
import { User } from '../user.model';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user-update',
  templateUrl: './user-update.component.html',
  styleUrls: ['./user-update.component.css']
})
export class UserUpdateComponent implements OnInit {
  user: User = new User();
  form: FormGroup;
  listSelectSchooling: { value: number, option: string }[] = [];
  dataInvalida: boolean = false;
  emailInvalido: boolean = false;
  
  constructor(private router: Router, private formBuilder: FormBuilder, private userService: UserService, private route: ActivatedRoute) { }
  ngOnInit(): void {
    const id = Number(this.route.snapshot.paramMap.get("id"));
    console.log(id);
    this.initForm();
    this.enumToList();
    this.findUserById(id);
  }

  findUserById(id: number){
    this.userService.readById(id).subscribe(genericResult =>{
      this.user = genericResult.data;
    });
  }

  initForm(): void {
    this.form = this.formBuilder.group({
      id: [''],
      name: ['', Validators.required],
      email: ['', Validators.required],
      surname: ['', Validators.required],
      birthDate: ['', Validators.required],
      schooling: ['', Validators.required]
    });
  }

  enumToList() {
    for (var n in Schooling) {
      if (typeof Schooling[n] === 'number') {
        this.listSelectSchooling.push({ value: <any>Schooling[n], option: n });
      }
    }
  }

  updateUser(){
    this.userService.update(this.user).subscribe(genericResult =>{
      this.userService.showMessage(genericResult.message, !genericResult.success);
      this.router.navigate(['/users']);
    });
  }

  cancel(){
    this.router.navigate(['/users']);
  }

  validateDate(event: any) {
    let date = new Date(Date.parse(event));
    if (date > new Date()) {
      this.dataInvalida = true;
    }
    else {
      this.dataInvalida = false;
    }
  }

  validateEmail(event: any) {
    if (event == "" || event.indexOf('@') == -1 || event.indexOf('.') == -1) {
      this.emailInvalido = true;
    }
    else {
      this.emailInvalido = false;
    }
  }

}

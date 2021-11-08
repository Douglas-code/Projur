import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Schooling } from 'src/app/utils/enums/schooling.enum';
import { User } from '../user.model';
import { UserService } from '../user.service';


@Component({
  selector: 'app-user-create',
  templateUrl: './user-create.component.html',
  styleUrls: ['./user-create.component.css']
})
export class UserCreateComponent implements OnInit {
  user: User = new User();
  form: FormGroup;
  listSelectSchooling: { value: number, option: string }[] = [];
  dataInvalida: boolean = false;
  emailInvalido: boolean = false;

  constructor(private router: Router, private formBuilder: FormBuilder, private userService: UserService) { }

  ngOnInit(): void {
    this.initForm();
    this.enumToList();
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

  createUser(): void {
    console.log(this.user);
    if ((this.emailInvalido && this.dataInvalida) || this.form.invalid) {
      this.userService.showMessage("Erro ao criar usuário, por favor insira dados válidos", true);
    }
    else {
      this.userService.create(this.user).subscribe((genericResult) => {
        this.userService.showMessage(genericResult.message, !genericResult.success);
        this.router.navigate(['/users']);
      });
    }
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

  cancel(): void {
    this.router.navigate(['/users']);
  }
}

import { Injectable } from "@angular/core";
import { MatSnackBar } from "@angular/material/snack-bar";
import { HttpClient } from "@angular/common/http";
import { Observable, EMPTY } from "rxjs";
import { map, catchError } from "rxjs/operators";
import { User } from "./user.model";
import { GenericResult } from "src/app/utils/models/GenericResult";

@Injectable({
  providedIn: "root",
})
export class UserService {
  baseUrl = "https://localhost:5001/users";

  constructor(private snackBar: MatSnackBar, private http: HttpClient) { }

  showMessage(msg: string, isError: boolean = false): void {
    this.snackBar.open(msg, "X", {
      duration: 3000,
      horizontalPosition: "right",
      verticalPosition: "top",
      panelClass: isError ? ["msg-error"] : ["msg-success"],
    });
  }

  create(user: User): Observable<GenericResult<User>> {
    return this.http.post<GenericResult<User>>(this.baseUrl, user).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  read(): Observable<GenericResult<User[]>> {
    return this.http.get<GenericResult<User[]>>(this.baseUrl).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  readById(id: number): Observable<GenericResult<User>> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.get<GenericResult<User>>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  update(user: User): Observable<GenericResult<User>> {
    const url = `${this.baseUrl}/${user.id}`;
    return this.http.put<GenericResult<User>>(url, user).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  delete(id: number): Observable<GenericResult<User>> {
    const url = `${this.baseUrl}/${id}`;
    return this.http.delete<GenericResult<User>>(url).pipe(
      map((obj) => obj),
      catchError((e) => this.errorHandler(e))
    );
  }

  errorHandler(e: any): Observable<any> {
    this.showMessage("Ocorreu um erro!", true);
    return EMPTY;
  }
}

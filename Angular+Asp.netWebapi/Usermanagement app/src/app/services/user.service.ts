import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { User } from '../model/user.model';
import { environment } from 'src/environments/environment';

@Injectable()
export class UserService {

  constructor(private http:HttpClient) { }
  // baseUrl:string = 'http://localhost:3000/users';
  baseUrl1:string = 'User';//"User"
  // this url should be modified to represent the url of the asp.net core webapi and the url value should be assigned in the iconfig service

  // Get All Users
  // getUsers(){
  //   return this.http.get<User[]>(this.baseUrl); //(`${environment.apiUrl}/${this.baseUrl}`)
  // }
 

  // // Get User By Id
  // getUserById(id: number){
  //   return this.http.get<User>(this.baseUrl+'/'+id);
  // }

  // // Create User
  // createUser(user: User) {
  //   return this.http.post(this.baseUrl, user);
  // }

  // // Modify User
  // updateUser(user: User) {
  //   return this.http.put(this.baseUrl + '/' + user.id, user);
  // }

  // // Delete User
  // deleteUser(id: number) {
  //   return this.http.delete(this.baseUrl + '/' + id);
  // }


//neeeeeeeeeeewwwwwwwwwwwwwwwwwwwwwwwwwwwwww
//newwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwwww

  getUser(){
    return this.http.get<User[]>(`${environment.apiUrl}/${this.baseUrl1}`); //(`${environment.apiUrl}/${this.baseUrl}`)
  }

  GetUserById(id: number){
    return this.http.get<User>(`${environment.apiUrl}/${this.baseUrl1}/${id}`);
  }

  // // Create User
  CreateUser(user: User) {
    return this.http.post<User>(`${environment.apiUrl}/${this.baseUrl1}`,user);
  }

  // Modify User
  UpdateUser(user: User) {
    return this.http.put(`${environment.apiUrl}/${this.baseUrl1}`,user);
  }

  // Delete User
  DeleteUser(id: number) {
    return this.http.delete(`${environment.apiUrl}/${this.baseUrl1}/${id}`);
  }

}


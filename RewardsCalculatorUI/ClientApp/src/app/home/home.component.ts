import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../Models/Customer';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent {
    public customers: Customer[] = [];
    private _baseUrl: string;
    constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
        this.getCustomers();
    }

    getCustomers() {
        this.http.get<Customer[]>(this._baseUrl + 'api/Customer').subscribe(res => {
            this.customers = res;
        }, err => console.error(err));
    }
}

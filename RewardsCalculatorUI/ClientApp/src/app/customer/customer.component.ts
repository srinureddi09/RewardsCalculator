import { Component, Inject, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Customer } from '../Models/Customer';
import { ActivatedRoute } from '@angular/router';
import { Transaction } from '../Models/Transaction';

@Component({
    selector: 'app-customer',
    templateUrl: './customer.component.html',
})
export class CustomerComponent implements OnInit {
    
    public customer: Customer;
    private customerId: number;
    private threeMonthsOld;
    private _baseUrl: string;
    constructor(private http: HttpClient, private route: ActivatedRoute, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
    }

    ngOnInit(): void {
        this.route.params.subscribe(params => {
            this.customerId = Number(params.id);
            this.getCustomerInfo();
        });
        this.threeMonthsOld = new Date().setMonth(new Date().getMonth() - 3);
    }

    getCustomerInfo() {
        this.http.get<Customer>(this._baseUrl + 'api/Customer/' + this.customerId).subscribe(res => {
            this.customer = res;
            this.customer.transactions.forEach(x => {
                x.rewardEarned = this.calculateRewards(x);
            });
        }, err => console.error(err));
    }

    calculateRewards(transaction: Transaction) {
        if (transaction.amount >= 50 && transaction.amount < 100) {
            return (transaction.amount - 50);
        } else if (transaction.amount > 100) {
            return (2 * (transaction.amount - 100) + 50);
        } else {
            return 0;
        }
    }

    calculteCurrentMonthRewards() {
        if (this.customer.transactions.length === 0)
            return 0;
        var currentMonthTransactions = this.customer.transactions.filter(x => new Date(x.date) >= new Date(new Date().getFullYear(), new Date().getMonth(), 1));
        return currentMonthTransactions.reduce(function (prev, cur) {
            return prev + cur.rewardEarned;
        }, 0);
    }

    calculatePastThreeMonthsRewards() {
        if (this.customer.transactions.length === 0)
            return 0;
        var pastThreeMonthsTransactions = this.customer.transactions.filter(x => new Date(x.date) >= new Date(this.threeMonthsOld));
        return pastThreeMonthsTransactions.reduce(function (prev, cur) {
            return prev + cur.rewardEarned;
        }, 0);
    }

    totalRewards() {
        if (this.customer.transactions.length === 0)
            return 0;
        return this.customer.transactions.reduce(function (prev, cur) {
            return prev + cur.rewardEarned;
        }, 0);
    }
}

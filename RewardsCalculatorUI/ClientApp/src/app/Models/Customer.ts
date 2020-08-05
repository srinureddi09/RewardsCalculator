import { Transaction } from '../Models/Transaction';

export class Customer {
    firstName: string;
    lastName: string;
    email: string;
    id: number;
    transactions: Transaction[];
}

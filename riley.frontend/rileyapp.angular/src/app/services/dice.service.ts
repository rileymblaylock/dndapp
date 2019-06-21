import { Injectable } from '@angular/core';
import { IRollDice } from '../interfaces/irolldice.service';
import { HttpService } from './http.service';

@Injectable()
export class DiceService implements IRollDice {
    constructor(public http: HttpService) { }

    public getRoll() {
        let url = `/api/Dice/`;
        return this.http.get(url);
    }

    public getRollNum(numSides: number) {
        let url = `/api/Dice/${numSides}`;
        return this.http.get(url);
    }
}
import { FormControl } from "@angular/forms";

export function dateValidator(control: FormControl) {

    let value: Date;
    value = new Date(control.value);
    console.log('Date', value);
    let nowDate= new Date();
    console.log('nowDate', nowDate);

    console.log('nowDate', nowDate > value);

    if (value > nowDate) {
return null;
    } else {
      return {
        'dateValidator': {
            valid: false
        }
    };
}
}

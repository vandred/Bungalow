import { FormControl } from "@angular/forms";

export function dateValidator(control: FormControl) {

    const value: Date = control.value;


    let nowDate= new Date();
    nowDate.setDate(nowDate.getDate() + 30);

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

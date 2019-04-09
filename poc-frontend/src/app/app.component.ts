import { Component } from '@angular/core';

declare var $: any;

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'poc-frontend';

  ngOnInit() : void {
    $(document).ready(function(){
      $('.sidenav').sidenav();
    });

  }
}

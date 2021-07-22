import { Component, Input, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { __importDefault } from 'tslib';

@Component({
  selector: 'app-titulo',
  templateUrl: './titulo.component.html',
  styleUrls: ['./titulo.component.scss']
})
export class TituloComponent implements OnInit {

  @Input() titulo = {} as string;
  @Input() iconClass = 'fa fa-user' as string;
  @Input() subtitulo = 'Desde 2021' as string;
  @Input() botaoListar = false as boolean;

  constructor(private router: Router) { }

  ngOnInit(): void {
  }

  listar(): void {
    this.router.navigate([`/${this.titulo.toLocaleLowerCase()}/lista`]);
  }
}

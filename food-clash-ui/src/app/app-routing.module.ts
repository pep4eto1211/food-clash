import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { ClashesComponent } from './containers/clashes/clashes.component';

const routes: Routes = [
    {
        path: '',
        redirectTo: 'clashes',
        pathMatch: 'full'
    },
    {
        path: 'clashes',
        component: ClashesComponent,
        children: [
            {
                path: '',
                redirectTo: 'home',
                pathMatch: 'full'
            },
            {
                path: 'home',
                component: HomeComponent
            }
        ]
    },
    { path: '**', redirectTo: '' },
];

@NgModule({
    imports: [RouterModule.forRoot(routes)],
    exports: [RouterModule]
})
export class AppRoutingModule { }

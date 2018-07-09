import Route from '@ember/routing/route';
import $ from 'jquery';
export default Route.extend({
model(){
$.get('http://localhost:5000/api/v1/people').done((response)=>{console.log(response)})
}
});
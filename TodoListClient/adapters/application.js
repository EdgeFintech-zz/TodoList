import DS from 'ember-data';
import ENV from 'todo-list-client/config/environment';

console.log('ENV', ENV);

export default DS.JSONAPIAdapter.extend({
    namespace: ENV.APP.namespace,
    host: ENV.APP.host
})
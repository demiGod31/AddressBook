<template>
  <div>
    <h2>Address Book</h2>
    <table class="table">
			<thead>
				<th>ID</th>
				<th>NAME</th>
				<th>NUMBER</th>
			</thead>

			<tbody>
				<tr :key="user.eId" v-for="user in response">
					<td>{{ user.eId }}</td>
					<td>{{ user.eName }}</td>
					<td>{{ user.eNumber }}</td>
					<td>
						<button class="btn btn-warning btn-sm">
              <router-link :to="{ name: 'update', params: {eID: user.eId,eNAME: user.eName,eNUMBER: user.eNumber} }">Update</router-link></button>
						<button class="btn btn-danger btn-sm">
              <router-link :to="{ name: 'delete', params: {eID: user.eId} }">Delete</router-link></button>
					</td>
				</tr>
			</tbody>
		</table>
  </div>
  </template>

<script>
import axios from 'axios';
  export default {
    data() {
      return {
        fields: ['address_id', 'name', 'number'],
        response:['']        
      }
    },
  
beforeCreate:async function() {
try{
  await axios.get('http://localhost:50069/api/AddressBook/Show').then((response) => {
    this.response = response.data;
    console.log(response)
    });
}
  catch(error)
  {
      alert(error);
  } 

}
    
  }
</script>